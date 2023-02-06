using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Model;
using Presenter;

namespace Views
{
	public partial class FrmEditColumnOrRow : Form, IEditColumnOrRow
	{
        //*************************************************

		EditColumnOrRowPresenter _editColumnOrRowPresenter;

        //*************************************************

        public FrmEditColumnOrRow(int index, string text, int mode, List<List<LocationNode>> locationNodes)
		{
			InitializeComponent();
			
			_editColumnOrRowPresenter = new EditColumnOrRowPresenter(index, text, mode, this, locationNodes);
		}

        // - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - [ PROPERTIES ]
        // - - - - - - - - - - - - - - - - - - 

        public int WorkAtIndex
		{	get {	return _editColumnOrRowPresenter.InsertAtIndex;	}	}

        public ComboBox ComboBox1
		{
			get {	return comboBox1;	}
			set	{	comboBox1 = value;	 }
		}

        public Label Label1
		{
			get { return label1; }
			set { label1 = value; }
		}

        public GroupBox GroupBox2
		{
			get { return groupBox2; }
			set { groupBox2 = value; }
		}

        //-------------------------------------------------------------------------------------

        void Btn_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;            
        }
	
		void Btn_AcceptClick(object sender, EventArgs e)
		{
			Accept.Invoke(this, EventArgs.Empty);
			this.DialogResult = DialogResult.OK;			
        }

        public event EventHandler Accept;
    }
}
