using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Presenter;
using Model;

namespace Views
{

	public partial class FrmMapperMain : Form, IMapperMain
	{
        //*************************************************
        
		DataTable DataDT;	
		int mapHeight;
		int mapWidht;
		string mapName;
		string title;
		bool savedFile;
		string filePath;
		
        //*************************************************
		
		public FrmMapperMain()
		{

			InitializeComponent();

			title = "2D MoonNewt Mapper";

            Data.InitializeData();
			DataDT = new DataTable();
			
			mapHeight = 100;
			mapWidht = 100;
			savedFile = false;
			
			UpdateTitle(this,"New Map");
			UpdateTitleName("New Map");

			//DrawTable();
			DrawTable2();
			InitializeGridWidth();			
		}
		
		// - - - - - - - - - - - - - - - - - - 
		// - - - - - - - - - - [ STRIP MENU ]
		// - - - - - - - - - - - - - - - - - - 
		
		public string UITitle
		{
			get	{	return this.title;	}
			set	{	this.title = value;	}
		}
		
		
		private void LoadFileToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "JSON Files ( *.json )|*.json";

			if(openFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Data.LocationNodes.Clear();
					JSONSerializer<List<List<LocationNode>>> serializer = new JSONSerializer<List<List<LocationNode>>>(openFile.FileName);
					Data.LocationNodes = serializer.DeSerialize();

					filePath = openFile.FileName;
					
					UpdateTitleName( Path.GetFileNameWithoutExtension( openFile.FileName ));

					//DrawTable();
					DrawTable2();
					SetNewCellDimenssions(mapWidht, mapHeight);
					savedFile = true;
				}
				catch
				{
					
				}
			}			
		}
		
		// * * * * * * * * * *
		
		private void SaveFileToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileAs();			
		}

		private void SaveFileAs()
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = "JSON Files ( *.json )|*.json";

			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					JSONSerializer<List<List<LocationNode>>> serializer = new JSONSerializer<List<List<LocationNode>>>(saveFile.FileName);

					serializer.Serialize(Data.LocationNodes);

					filePath = saveFile.FileName;

					UpdateTitleName(Path.GetFileNameWithoutExtension(saveFile.FileName));
					savedFile = true;
				}
				catch
				{

				}
			}
		}

		// * * * * * * * * * *

		private void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		// * * * * * * * * * *
		
		private void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if(Data.LocationNodes[rowIndex].ElementAtOrDefault(columnIndex) != null)
            {
            	if((ModifierKeys & Keys.Control) == Keys.Control || chkBox_TileDetails.Checked)
				{				
					FrmTileDetails frmTileDetails = new FrmTileDetails(Data.LocationNodes[rowIndex][columnIndex]);
	
					if(frmTileDetails.ShowDialog() == DialogResult.OK)
					{
						Data.LocationNodes[rowIndex][columnIndex].LocationImage = frmTileDetails.FakeLocationNode.LocationImage;
						Data.LocationNodes[rowIndex][columnIndex].Description = frmTileDetails.FakeLocationNode.Description;
						Data.LocationNodes[rowIndex][columnIndex].LocationName = frmTileDetails.FakeLocationNode.LocationName;
						Data.LocationNodes[rowIndex][columnIndex].LocationType = frmTileDetails.FakeLocationNode.LocationType;

						//DrawTable();
						DrawTable2();
	                    SetNewCellDimenssions(mapWidht, mapHeight);
	                }	
				}			
	
				else if (!chkBox_TileDetails.Checked)
				{
	                PictureSerializer picSerializer = new PictureSerializer();
	                string newImage = picSerializer.UploadImageAsString();
	
	                if (newImage != "")
	                {
	                    Data.LocationNodes[rowIndex][columnIndex].LocationImage = newImage;

                        //DrawTable();
                        DrawTable2();
                        SetNewCellDimenssions(mapWidht, mapHeight);
	                }
	            }
            }			
		}
		
		// * * * * * * * * * *
		
		//private void DrawTable()
  //      {
		//	dataGridView1.DataSource = null;
  //          DataDT.Columns.Clear();
  //          DataDT.Rows.Clear();
                        
            
  //          for (int i = 0; i < Data.LocationNodes[0].Count; i++)
  //          {
  //              DataDT.Columns.Add("X" + i, typeof(Bitmap));
  //          }

  //          for (int i = 0; i < Data.LocationNodes.Count; i++)
  //          {
  //          	DataDT.Rows.Add();
            	
  //              int count = 0;                               
                
  //              foreach (LocationNode node in Data.LocationNodes[i])
  //              {
  //              	PictureSerializer picSerializer = new PictureSerializer();
                	                	
  //              	DataDT.Rows[i][count] = picSerializer.TurnStringToImage(Data.LocationNodes[i][count].LocationImage);
  //                  count++;                    
  //              }
  //          }            
            
		//	dataGridView1.DataSource = DataDT;
			
		//	SetCellsToStretch();
		//}
		
		// * * * * * * * * * *
		
		private void DrawTable2()
		{
			PictureSerializer pictureSerializer = new PictureSerializer();

            dataGridView1.DataSource = null;
			dataGridView1.Columns.Clear();
			dataGridView1.Rows.Clear();
            dataGridView1.AutoGenerateColumns = false;            

			for (int i = 0; i < Data.LocationNodes[0].Count; i++)
			{
				DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
				imageCol.Name = "X " + i;
				imageCol.HeaderText = "X " + i;				
				dataGridView1.Columns.Add(imageCol);
			}
			for (int i = 0; i < Data.LocationNodes.Count; i++)
			{
				dataGridView1.Rows.Add();
				dataGridView1.Rows[i].HeaderCell.Value = "Y " + i;
            }
			
			dataGridView1.RowHeadersWidth = 60;

			for (int i = 0; i < Data.LocationNodes.Count; i++)
			{
				for (int j = 0; j < Data.LocationNodes[i].Count; j++)
				{					
					dataGridView1.Rows[i].Cells[j].Value = new Bitmap(pictureSerializer.TurnStringToImage(Data.LocationNodes[i][j].LocationImage));					
                }
			}
			SetCellsToStretch();
        }

        // * * * * * * * * * *

        private void NewMapToolStripMenuItemClick(object sender, EventArgs e)
		{
			FrmNewMap newMap = new FrmNewMap();
			
			if(newMap.ShowDialog() == DialogResult.OK)
			{
				Data.LocationNodes.Clear();
				
				int height = newMap.CellHeight;
				int width = newMap.CellWidth;
				
				for (int i = 0; i < height; i++)
				{
					List<LocationNode> newNodesList = new List<LocationNode>();
					
					Data.LocationNodes.Add(newNodesList);
					
					for (int j = 0; j < width; j++)
					{
						PictureSerializer pictureSerializer = new PictureSerializer();
						LocationNode newLocationNode = new LocationNode();
						
						newLocationNode.LocationImage = pictureSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);
						
						newNodesList.Add(newLocationNode);
					}
				}
				
				savedFile = false;
				filePath = "";
				DrawTable2();
			}
		}
		
		// * * * * * * * * * *
		
		private void Btn_InsertColumnClick(object sender, EventArgs e)
		{
			if(Data.LocationNodes != null && Data.LocationNodes.Count > 0)
			{
				FrmEditColumnOrRow insertColumn = new FrmEditColumnOrRow(Data.LocationNodes[0].Count, "Index to insert at", 1);
				
				if( insertColumn.ShowDialog() == DialogResult.OK )
				{
					int insertAtIndex = insertColumn.WorkAtIndex;
					
					for (int i = 0; i < Data.LocationNodes.Count; i++)
					{
                        PictureSerializer pictureSerializer = new PictureSerializer();
                        LocationNode newLocationNode = new LocationNode();
						newLocationNode.LocationImage = pictureSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);

                        Data.LocationNodes[i].Insert(insertAtIndex, newLocationNode);
					}
					
					DrawTable2();
				}
			}			
		}
		
		// * * * * * * * * * *
		
		private void Btn_InsertRowClick(object sender, EventArgs e)
		{
			if(Data.LocationNodes != null && Data.LocationNodes.Count > 0)
			{
				FrmEditColumnOrRow insertColumn = new FrmEditColumnOrRow(Data.LocationNodes.Count, "Index to insert at", 1);
				
				if( insertColumn.ShowDialog() == DialogResult.OK )
				{
					int insertAtIndex = insertColumn.WorkAtIndex;
					
					List<LocationNode> newNodesList = new List<LocationNode>();
					
					for (int i = 0; i < Data.LocationNodes[0].Count; i++)
					{
                        PictureSerializer pictureSerializer = new PictureSerializer();
                        LocationNode newLocationNode = new LocationNode();
                        newLocationNode.LocationImage = pictureSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);

                        newNodesList.Add(newLocationNode);
					}
					
					Data.LocationNodes.Insert(insertAtIndex, newNodesList);
					
					DrawTable2();
				}
			}
		}
		
		// * * * * * * * * * *
		
		private void InitializeGridWidth()
		{
			for (int i = 0; i < dataGridView1.Columns.Count; i++)
			{
				dataGridView1.Columns[i].Width = 100;
			}			
		}
		
		// * * * * * * * * * *
		
		private void SetNewCellDimenssions(int width, int height)
		{
			for (int i = 0; i < dataGridView1.Columns.Count; i++)
			{
				dataGridView1.Columns[i].Width = width;
			}
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				dataGridView1.Rows[i].Height = height;
			}
		}
		
		// * * * * * * * * * *
		
		private void SetCellsToStretch()
		{
			for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {            	
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }                
            }
		}
		
		// * * * * * * * * * *
		
		private void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			switch(Convert.ToInt32(trackBar1.Value))
			{
				case 0:
					SetNewCellDimenssions(100,100);
					mapWidht = 100; mapHeight = 100;
					break;
				case 1:
					SetNewCellDimenssions(90,90);
					mapWidht = 90; mapHeight = 90;
					break;
				case 2:
					SetNewCellDimenssions(80,80);
					mapWidht = 80; mapHeight = 80;
					break;
				case 3:
					SetNewCellDimenssions(70,70);
					mapWidht = 70; mapHeight = 70;
					break;
				case 4:
					SetNewCellDimenssions(60,60);
					mapWidht = 60; mapHeight = 60;
					break;
				case 5:
					SetNewCellDimenssions(50,50);
					mapWidht = 50; mapHeight = 50;
					break;
			}
		}
		
		// * * * * * * * * * *
		
		private void Btn_ClearMapClick(object sender, EventArgs e)
		{
			if(Data.LocationNodes != null && Data.LocationNodes.Count > 0)
			{
				for (int i = 0; i < Data.LocationNodes.Count; i++)
				{
					for (int j = 0; j < Data.LocationNodes[i].Count; j++)
					{
						if(Data.LocationNodes[i][j] != null && Data.LocationNodes[i][j].LocationImage != "")
						{
							PictureSerializer pictureSerializer = new PictureSerializer();
							
							Data.LocationNodes[i][j].LocationImage = pictureSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);
							Data.LocationNodes[i][j].Description = "";
                            Data.LocationNodes[i][j].LocationName = "";
							Data.LocationNodes[i][j].LocationType = "";
							Data.LocationNodes[i][j].X = 0;
							Data.LocationNodes[i][j].Y = 0;
                        }
					}
				}
				
				DrawTable2();
				SetNewCellDimenssions(mapWidht, mapHeight);
			}
		}
		
		// * * * * * * * * * *
		
		public event EventHandler<string> UpdateTitle;
		
		private void UpdateTitleName(string fileName)
		{
            mapName = fileName;
            this.Text = title + " * * * [ " + mapName + " ]";
        }
		
		// * * * * * * * * * *

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!savedFile)
			{
				SaveFileAs();
			}
			else
			{
                JSONSerializer<List<List<LocationNode>>> serializer = new JSONSerializer<List<List<LocationNode>>>(filePath);

                serializer.Serialize(Data.LocationNodes);
            }
		}
		
		// * * * * * * * * * *

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("===[About the MAP]===\n\n" +
							"CTRL + RIGHT CLICK on any tile opens the detailed tile form. Alternatively you can check that option on the map's left side.\n" +
                            "DOUBLE CLICK on any tile opens the Upload Picture dialog for that tile.");
		}
		
		// * * * * * * * * * *
		
		void GenerateMapToolStripMenuItemClick(object sender, EventArgs e)
		{
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PNG Files ( *.png )|*.png";

            if (saveFile.ShowDialog() == DialogResult.OK)
			{
				CombinePictures(saveFile.FileName);
			}
        }
		
		// * * * * * * * * * *
		
		private void CombinePictures(string filePath)
		{
			int width = 0;
			int height = 0;
						
			PictureSerializer serializer = new PictureSerializer();
			
			if(Data.LocationNodes.Count > 0)
			{
				// WIDHT
				foreach(LocationNode node in Data.LocationNodes[0])
	            {	            	
	            	Bitmap locationImage = serializer.TurnStringToImage(node.LocationImage);
	            	width += locationImage.Width;
	            }  
				
				// HEIGHT
				foreach(List<LocationNode> listOfNodes in Data.LocationNodes)
				{
					Bitmap locationImage = serializer.TurnStringToImage(listOfNodes[0].LocationImage);
					height += locationImage.Height;
				}
				
				// - - - - -
				
				Bitmap map = new Bitmap(width, height);
				Graphics graphics = Graphics.FromImage(map);				
				
				int width2 = 0;
				int height2 = 0;
				bool firstPict = true;
				bool firstList = true;
				bool firstNode = true;
				
				foreach(LocationNode node in Data.LocationNodes[0])
				{
					if(firstPict == true)
					{
						Bitmap tile = serializer.TurnStringToImage(node.LocationImage);
						graphics.DrawImage(tile, new Point(0, 0));
						firstPict = false;
						width2 += tile.Width;
					}
					else
					{
						Bitmap tile = serializer.TurnStringToImage(node.LocationImage);
						graphics.DrawImage(tile, new Point(width2, 0));
						width2 += tile.Width;
					}
				}
				
				foreach( List<LocationNode> listOfNodes in Data.LocationNodes)
				{
					if(firstList == false)
					{
						width2 = 0;
						firstNode = true;
						foreach(LocationNode node in listOfNodes)
						{
							Bitmap tile = serializer.TurnStringToImage(node.LocationImage);
							
							if(firstNode == true)
							{
								height2 += tile.Height;
								firstNode = false;
							}
							
							graphics.DrawImage(tile, new Point(width2, height2));
							width2 += tile.Width;

						}
					}
					else
					{
						firstList = false;
					}
				}
				
				map.Save(filePath);
			}
		}
		
		// * * * * * * * * * *		

		void Btn_RemoveColumnClick(object sender, EventArgs e)
		{
			FrmEditColumnOrRow removeColumn = new FrmEditColumnOrRow(Data.LocationNodes[0].Count, "Index to remove at", 2);
			
			if(removeColumn.ShowDialog() == DialogResult.OK)
			{
				foreach(List<LocationNode> listOfNodes in Data.LocationNodes)
				{
					listOfNodes.RemoveAt(removeColumn.WorkAtIndex);
				}
				DrawTable2();
				SetNewCellDimenssions(mapWidht, mapHeight);
			}
		}
		
		
		void Btn_RemoveRowClick(object sender, EventArgs e)
		{
			FrmEditColumnOrRow removeRow = new FrmEditColumnOrRow(Data.LocationNodes.Count, "Index to remove at", 3);
			
			if(removeRow.ShowDialog() == DialogResult.OK)
			{
				Data.LocationNodes.RemoveAt(removeRow.WorkAtIndex);
				DrawTable2();
				SetNewCellDimenssions(mapWidht, mapHeight);
			}			
		}		
	}
}
