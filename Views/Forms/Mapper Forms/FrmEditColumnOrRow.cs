using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace Views
{
	public partial class FrmEditColumnOrRow : Form
	{		
		int insertAtIndex;
		int mode;
		
		public FrmEditColumnOrRow(int index, string text, int mode)
		{
			InitializeComponent();

			this.mode = mode;

			for (int i = 0; i < index; i++)
			{
				comboBox1.Items.Add(i);
			}
			
			groupBox2.Text = text;

		}

		public int WorkAtIndex
		{	get {	return insertAtIndex;	}	}
	
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	
		void Btn_AcceptClick(object sender, EventArgs e)
		{
			if(comboBox1.SelectedItem != null && mode == 1)
			{
				insertAtIndex = (int)comboBox1.SelectedItem;
			
				this.DialogResult = DialogResult.OK;
			}
			else if(comboBox1.SelectedItem != null && mode ==2)
			{
				if (Data.LocationNodes[0].Count == 1)
				{
					label1.Visible = true;
					label1.Text = "You cannot remove any more columns.";
				}
				else
				{
                    insertAtIndex = (int)comboBox1.SelectedItem;

                    this.DialogResult = DialogResult.OK;
                }
			}
            else if (comboBox1.SelectedItem != null && mode == 3)
			{
                if (Data.LocationNodes.Count == 1)
                {
                    label1.Visible = true;
                    label1.Text = "You cannot remove any more rows.";
                }
                else
                {
                    insertAtIndex = (int)comboBox1.SelectedItem;

                    this.DialogResult = DialogResult.OK;
                }
            }
        }		
	}
}
