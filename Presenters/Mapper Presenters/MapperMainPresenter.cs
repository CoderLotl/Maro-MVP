using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Model;
using Views;

namespace Presenter
{
	public class MapperMainPresenter
	{
		//*************************************************
		
		DataTable DataDT;	
		int mapHeight;
		int mapWidht;
		string mapName;
		string title;
		bool savedFile;
		string filePath;
		List<List<LocationNode>> locationNodes;
		IMapperMain _mapperMain;
				
		//*************************************************
		
		public MapperMainPresenter(IMapperMain mapperMain)
		{
			_mapperMain = mapperMain;

			Subscribe();
			InitializeData();
			DrawTable2();
			InitializeGridWidth();
		}
		
		//-------------------------------------------------------------------------------------
		
		private void Subscribe()
		{
			_mapperMain.UpdateTitle += (e, o) =>
			{				
				UpdateTitle(o);
			};

			_mapperMain.InitializeData += (e, o) =>
			{
				InitializeData();
			};
			
			_mapperMain.LoadFileToolStripMenu += (e, o) =>
			{
				LoadFileToolStripMenuItemClick();
			};
			
			_mapperMain.SaveFileToolStripMenu += (e, o) =>
			{
				SaveFileAs();
			};
			
			_mapperMain.DataGridViewCellDoubleClick += (e, o) =>
			{
				DVGridDoubleClick(o);
			};
			
			_mapperMain.NewMap += (e, o) =>
			{
				NewMap();
			};
			
			_mapperMain.InsertNewColumn += (e, o) =>
			{
				InsertColumn();
			};
			
			_mapperMain.InsertNewRow += (e, o) =>
			{
				InsertRow();
			};
			
			_mapperMain.TrackbarChanged += (e, o) =>
			{
				TrackBarValueChanged();
			};
			
			_mapperMain.ClearMap += (e, o) =>
			{
				ClearMap();
			};
			
			_mapperMain.SaveFile += (e, o) =>
			{
				SaveFile();
			};
			
			_mapperMain.GenerateMap += (e, o) =>
			{
				GenerateMap();
			};
			
			_mapperMain.RemoveColumn += (e, o) =>
			{
				RemoveColumn();
			};
			
			_mapperMain.RemoveRow += (e, o) =>
			{
				RemoveRow();
			};
		}
		
		//------------------
		
		private void InitializeData()
		{
            title = "2D CoderLotl Mapper";
            
            DataDT = new DataTable();

            mapHeight = 100;
            mapWidht = 100;
            savedFile = false;

            locationNodes = new List<List<LocationNode>>();
			
			for(int i = 0; i < 5; i++)
			{
				List<LocationNode> listOfNodes = new List<LocationNode>();
				locationNodes.Add(listOfNodes);
				for (int j = 0; j < 5; j++)
				{
					LocationNode newNode = new LocationNode();
					PictureSerializer picSerializer = new PictureSerializer();

                    newNode.LocationImage = picSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);

                    listOfNodes.Add(newNode);
				}
			}
		}
		
		//------------------
		
		private void UpdateTitle(string arg)
		{
			_mapperMain.UITitle = title + " * * * [ " + arg + " ]";
		}
		
		//------------------
		
		private void LoadFileToolStripMenuItemClick()
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Filter = "JSON Files ( *.json )|*.json";

			if(openFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					locationNodes.Clear();
					JSONSerializer<List<List<LocationNode>>> serializer = new JSONSerializer<List<List<LocationNode>>>(openFile.FileName);
					locationNodes = serializer.DeSerialize();

					filePath = openFile.FileName;
					
					UpdateTitle( Path.GetFileNameWithoutExtension( openFile.FileName ));
					
					DrawTable2();
					SetNewCellDimenssions(mapWidht, mapHeight);
					savedFile = true;
				}
				catch
				{
					
				}
			}			
		}
		
		//------------------
		
		private void SaveFileAs()
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Filter = "JSON Files ( *.json )|*.json";

			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					JSONSerializer<List<List<LocationNode>>> serializer = new JSONSerializer<List<List<LocationNode>>>(saveFile.FileName);

					serializer.Serialize(locationNodes);

					filePath = saveFile.FileName;

					UpdateTitle(Path.GetFileNameWithoutExtension(saveFile.FileName));
					savedFile = true;
				}
				catch
				{

				}
			}
		}
		
		//------------------
		
		private void DVGridDoubleClick(int check)
		{
			int columnIndex = _mapperMain.DGV.CurrentCell.ColumnIndex;
            int rowIndex = _mapperMain.DGV.CurrentCell.RowIndex;

            if(locationNodes[rowIndex].ElementAtOrDefault(columnIndex) != null)
            {
            	if(check == 1)
				{				
					FrmTileDetails frmTileDetails = new FrmTileDetails(locationNodes[rowIndex][columnIndex]);
	
					if(frmTileDetails.ShowDialog() == DialogResult.OK)
					{
						locationNodes[rowIndex][columnIndex].LocationImage = frmTileDetails.FakeLocationNode.LocationImage;
						locationNodes[rowIndex][columnIndex].Description = frmTileDetails.FakeLocationNode.Description;
						locationNodes[rowIndex][columnIndex].LocationName = frmTileDetails.FakeLocationNode.LocationName;
						locationNodes[rowIndex][columnIndex].LocationType = frmTileDetails.FakeLocationNode.LocationType;

						//DrawTable();
						DrawTable2();
	                    SetNewCellDimenssions(mapWidht, mapHeight);
	                }	
				}			
	
				else if (!_mapperMain.ChckBoxTileDetails.Checked)
				{
	                PictureSerializer picSerializer = new PictureSerializer();
	                string newImage = picSerializer.UploadImageAsString();
	
	                if (newImage != "")
	                {
	                    locationNodes[rowIndex][columnIndex].LocationImage = newImage;

                        //DrawTable();
                        DrawTable2();
                        SetNewCellDimenssions(mapWidht, mapHeight);
	                }
	            }
            }
		}
		
		//------------------
		
		private void DrawTable2()
		{
			PictureSerializer pictureSerializer = new PictureSerializer();

            _mapperMain.DGV.DataSource = null;
			_mapperMain.DGV.Columns.Clear();
			_mapperMain.DGV.Rows.Clear();
            _mapperMain.DGV.AutoGenerateColumns = false;            

			for (int i = 0; i < locationNodes[0].Count; i++)
			{
				DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
				imageCol.Name = "X " + i;
				imageCol.HeaderText = "X " + i;				
				_mapperMain.DGV.Columns.Add(imageCol);
			}
			for (int i = 0; i < locationNodes.Count; i++)
			{
				_mapperMain.DGV.Rows.Add();
				_mapperMain.DGV.Rows[i].HeaderCell.Value = "Y " + i;
            }
			
			_mapperMain.DGV.RowHeadersWidth = 60;

			for (int i = 0; i < locationNodes.Count; i++)
			{
				for (int j = 0; j < locationNodes[i].Count; j++)
				{					
					_mapperMain.DGV.Rows[i].Cells[j].Value = new Bitmap(pictureSerializer.TurnStringToImage(locationNodes[i][j].LocationImage));					
                }
			}
			SetCellsToStretch();
        }
		
		//------------------
		
		private void SetCellsToStretch()
		{
			for (int i = 0; i < _mapperMain.DGV.Columns.Count; i++)
            {            	
                if (_mapperMain.DGV.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)_mapperMain.DGV.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                }                
            }
		}
		
		//------------------
		
		private void SetNewCellDimenssions(int width, int height)
		{
			for (int i = 0; i < _mapperMain.DGV.Columns.Count; i++)
			{
				_mapperMain.DGV.Columns[i].Width = width;
			}
			for (int i = 0; i < _mapperMain.DGV.Rows.Count; i++)
			{
				_mapperMain.DGV.Rows[i].Height = height;
			}
		}
		
		//------------------
		
		private void InitializeGridWidth()
		{
			for (int i = 0; i < _mapperMain.DGV.Columns.Count; i++)
			{
				_mapperMain.DGV.Columns[i].Width = 100;
			}			
		}
		
		//------------------
		
		private void NewMap()
		{
			FrmNewMap newMap = new FrmNewMap();
			
			if(newMap.ShowDialog() == DialogResult.OK)
			{
				locationNodes.Clear();
				
				int height = newMap.CellHeight;
				int width = newMap.CellWidth;
				
				for (int i = 0; i < height; i++)
				{
					List<LocationNode> newNodesList = new List<LocationNode>();
					
					locationNodes.Add(newNodesList);
					
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
		
		//------------------
		
		private void InsertColumn()
		{
			if(locationNodes != null && locationNodes.Count > 0)
			{
				FrmEditColumnOrRow insertColumn = new FrmEditColumnOrRow(locationNodes[0].Count, "Index to insert at", 1, locationNodes);
				
				if( insertColumn.ShowDialog() == DialogResult.OK )
				{
					int insertAtIndex = insertColumn.WorkAtIndex;
					
					for (int i = 0; i < locationNodes.Count; i++)
					{
                        PictureSerializer pictureSerializer = new PictureSerializer();
                        LocationNode newLocationNode = new LocationNode();
						newLocationNode.LocationImage = pictureSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);

                        locationNodes[i].Insert(insertAtIndex, newLocationNode);
					}
					
					DrawTable2();
				}
			}			
		}
		
		//------------------
		
		private void InsertRow()
		{
			if(locationNodes != null && locationNodes.Count > 0)
			{
				FrmEditColumnOrRow insertColumn = new FrmEditColumnOrRow(locationNodes.Count, "Index to insert at", 1, locationNodes);
				
				if( insertColumn.ShowDialog() == DialogResult.OK )
				{
					int insertAtIndex = insertColumn.WorkAtIndex;
					
					List<LocationNode> newNodesList = new List<LocationNode>();
					
					for (int i = 0; i < locationNodes[0].Count; i++)
					{
                        PictureSerializer pictureSerializer = new PictureSerializer();
                        LocationNode newLocationNode = new LocationNode();
                        newLocationNode.LocationImage = pictureSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);

                        newNodesList.Add(newLocationNode);
					}
					
					locationNodes.Insert(insertAtIndex, newNodesList);
					
					DrawTable2();
				}
			}
		}
		
		//------------------
		
		private void TrackBarValueChanged()
		{
			switch(Convert.ToInt32(_mapperMain.Trackbar.Value))
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
		
		//------------------
		
		private void ClearMap()
		{
			if(locationNodes != null && locationNodes.Count > 0)
			{
				for (int i = 0; i < locationNodes.Count; i++)
				{
					for (int j = 0; j < locationNodes[i].Count; j++)
					{
						if(locationNodes[i][j] != null && locationNodes[i][j].LocationImage != "")
						{
							PictureSerializer pictureSerializer = new PictureSerializer();
							
							locationNodes[i][j].LocationImage = pictureSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);
							locationNodes[i][j].Description = "";
                            locationNodes[i][j].LocationName = "";
							locationNodes[i][j].LocationType = "";
							locationNodes[i][j].X = 0;
							locationNodes[i][j].Y = 0;
                        }
					}
				}
				
				DrawTable2();
				SetNewCellDimenssions(mapWidht, mapHeight);
			}
		}
		
		//------------------
		
		private void SaveFile()
		{
			if (!savedFile)
			{
				SaveFileAs();
			}
			else
			{
                JSONSerializer<List<List<LocationNode>>> serializer = new JSONSerializer<List<List<LocationNode>>>(filePath);

                serializer.Serialize(locationNodes);
            }
		}
		
		//------------------
		
		private void GenerateMap()
		{
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PNG Files ( *.png )|*.png";

            if (saveFile.ShowDialog() == DialogResult.OK)
			{
				CombinePictures(saveFile.FileName);
			}
        }
		
		//------------------
		
		private void CombinePictures(string filePath)
		{
			int width = 0;
			int height = 0;
						
			PictureSerializer serializer = new PictureSerializer();
			
			if(locationNodes.Count > 0)
			{
				// WIDHT
				foreach(LocationNode node in locationNodes[0])
	            {	            	
	            	Bitmap locationImage = serializer.TurnStringToImage(node.LocationImage);
	            	width += locationImage.Width;
	            }  
				
				// HEIGHT
				foreach(List<LocationNode> listOfNodes in locationNodes)
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
				
				foreach(LocationNode node in locationNodes[0])
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
				
				foreach( List<LocationNode> listOfNodes in locationNodes)
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
		
		//------------------
		
		void RemoveColumn()
		{
			FrmEditColumnOrRow removeColumn = new FrmEditColumnOrRow(locationNodes[0].Count, "Index to remove at", 2, locationNodes);
			
			if(removeColumn.ShowDialog() == DialogResult.OK)
			{
				foreach(List<LocationNode> listOfNodes in locationNodes)
				{
					listOfNodes.RemoveAt(removeColumn.WorkAtIndex);
				}
				DrawTable2();
				SetNewCellDimenssions(mapWidht, mapHeight);
			}
		}
		
		//------------------
		
		void RemoveRow()
		{
			FrmEditColumnOrRow removeRow = new FrmEditColumnOrRow(locationNodes.Count, "Index to remove at", 3, locationNodes);
			
			if(removeRow.ShowDialog() == DialogResult.OK)
			{
				locationNodes.RemoveAt(removeRow.WorkAtIndex);
				DrawTable2();
				SetNewCellDimenssions(mapWidht, mapHeight);
			}			
		}	
		
	}
}