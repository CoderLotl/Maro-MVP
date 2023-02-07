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

		MapperMainPresenter mapperMainPresenter;
		
        //*************************************************
		
		public FrmMapperMain()
		{
			InitializeComponent();

			mapperMainPresenter = new MapperMainPresenter(this);
			
			UpdateTitle.Invoke(this, "New Map");
		}

        // - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - [ PROPERTIES ]
        // - - - - - - - - - - - - - - - - - - 

        public string UITitle
		{
			get	{	return this.Text;	}
			set	{	this.Text = value;	}
		}
        
        public DataGridView DGV
		{
        	get	{	return dataGridView1;	}
        	set	{	dataGridView1 = value;	}
		}
        
		public CheckBox ChckBoxTileDetails
		{
			get	{	return chkBox_TileDetails;	}
			set	{	chkBox_TileDetails = value;	}
		}
		
		public TrackBar Trackbar
		{
			get	{	return trackBar1;	}
			set	{	trackBar1 = value;	}
		}
		
		// - - - - - - - - - - - - - - - - - - 
		// - - - - - - - - - - [ STRIP MENU ]
		// - - - - - - - - - - - - - - - - - - 
		
		
		
		private void LoadFileToolStripMenuItemClick(object sender, EventArgs e)
		{
			LoadFileToolStripMenu.Invoke(this, EventArgs.Empty);
		}
		
		// * * * * * * * * * *
		
		private void SaveFileToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileToolStripMenu.Invoke(this, EventArgs.Empty);
		}

		// * * * * * * * * * *

		private void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		// * * * * * * * * * *
		
		private void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int check = 0;
			if((ModifierKeys & Keys.Control) == Keys.Control || chkBox_TileDetails.Checked)
			{
				check = 1;
			}
			else
			{
				check = 0;
			}
            	
			DataGridViewCellDoubleClick.Invoke(this, check);				
		}
		
        // * * * * * * * * * *

        private void NewMapToolStripMenuItemClick(object sender, EventArgs e)
		{
			NewMap(this, EventArgs.Empty);
		}
		
		// * * * * * * * * * *
		
		private void Btn_InsertColumnClick(object sender, EventArgs e)
		{
			InsertNewColumn.Invoke(this, EventArgs.Empty);
		}
		
		// * * * * * * * * * *
		
		private void Btn_InsertRowClick(object sender, EventArgs e)
		{
			InsertNewRow.Invoke(this, EventArgs.Empty);
		}
		
		// * * * * * * * * * *
		
		private void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			TrackbarChanged.Invoke(this, EventArgs.Empty);
		}
		
		// * * * * * * * * * *
		
		private void Btn_ClearMapClick(object sender, EventArgs e)
		{
			ClearMap.Invoke(this, EventArgs.Empty);
		}
		
		// * * * * * * * * * *

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFile.Invoke(this, EventArgs.Empty);
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
			GenerateMap.Invoke(this, EventArgs.Empty);
        }
		
		// * * * * * * * * * *		

		void Btn_RemoveColumnClick(object sender, EventArgs e)
		{
			RemoveColumn.Invoke(this, EventArgs.Empty);
		}

        // * * * * * * * * * *

        void Btn_RemoveRowClick(object sender, EventArgs e)
		{
			RemoveRow.Invoke(this, EventArgs.Empty);
		}
		
		// * * * * * * * * * *
		
		public event EventHandler<string> UpdateTitle;
		public event EventHandler InitializeData;
		public event EventHandler LoadFileToolStripMenu;
		public event EventHandler SaveFileToolStripMenu;
		public event EventHandler<int> DataGridViewCellDoubleClick;
		public event EventHandler NewMap;
		public event EventHandler InsertNewColumn;
		public event EventHandler InsertNewRow;
		public event EventHandler TrackbarChanged;
		public event EventHandler ClearMap;
		public event EventHandler SaveFile;
		public event EventHandler GenerateMap;
		public event EventHandler RemoveColumn;
		public event EventHandler RemoveRow;
	}
}
