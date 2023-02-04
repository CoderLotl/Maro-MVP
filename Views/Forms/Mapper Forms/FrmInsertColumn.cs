using System;
using System.Windows.Forms;

namespace Views
{
	public partial class FrmInsertColumn : Form
	{
		int maxIndex;
		int insertAtIndex;
		
		public FrmInsertColumn(int maxIndex)
		{
			InitializeComponent();
			this.maxIndex = maxIndex;
			
			insertAtIndex = 0;
			nud_IndexToInsert.Maximum = maxIndex;
			
			label1.Text = "Max index: " + maxIndex;
		}

		public int InsertAtIndex
		{	get {	return insertAtIndex;	}	}
	
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	
		void Btn_AcceptClick(object sender, EventArgs e)
		{
			insertAtIndex = Convert.ToInt32( nud_IndexToInsert.Value );
			
			this.DialogResult = DialogResult.OK;
		}
		
		
	}
}
