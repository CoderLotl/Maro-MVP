using System;
using System.Windows.Forms;

namespace Views
{
	public interface IMapperMain
	{
		
		string UITitle
		{
			get; set;
		}
		
		DataGridView DGV
		{
			get; set;
		}
		
		CheckBox ChckBoxTileDetails
		{
			get; set;
		}
		
		TrackBar Trackbar
		{
			get; set;
		}

		event EventHandler InitializeData;
		event EventHandler<string> UpdateTitle;
		event EventHandler LoadFileToolStripMenu;
		event EventHandler SaveFileToolStripMenu;
		event EventHandler<int> DataGridViewCellDoubleClick;
		event EventHandler NewMap;
		event EventHandler InsertNewColumn;
		event EventHandler InsertNewRow;
		event EventHandler TrackbarChanged;
		event EventHandler ClearMap;
		event EventHandler SaveFile;
		event EventHandler GenerateMap;
		event EventHandler RemoveColumn;
		event EventHandler RemoveRow;
	}
}
