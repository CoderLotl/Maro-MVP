using System;
using System.Windows.Forms;

namespace Views
{
	public partial class FrmNewMap : Form
	{
		int height;
		int width;
		
		public FrmNewMap()
		{

			InitializeComponent();
			
			int height = 0;
			int width = 0;

		}

		public int CellHeight
		{
			get {	return height;	}
		}

		public int CellWidth
		{
			get {	return width;	}
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			height = Convert.ToInt32( numericUpDown1.Value );
		}
		void NumericUpDown2ValueChanged(object sender, EventArgs e)
		{
			width = Convert.ToInt32( numericUpDown2.Value );
		}
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		void Btn_AcceptClick(object sender, EventArgs e)
		{
			height = Convert.ToInt32(numericUpDown1.Value);
			width = Convert.ToInt32(numericUpDown2.Value);
			this.DialogResult = DialogResult.OK;
		}
	}
}
