using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Views;


namespace Presenter
{
    public class EditColumnOrRowPresenter
    {
        //*************************************************

        int insertAtIndex;
        int _mode;
        List<List<LocationNode>> _locationNodes;
        IEditColumnOrRow _editColumnOrRow;

        //*************************************************

        public EditColumnOrRowPresenter(int index, string text, int mode, IEditColumnOrRow editColumnOrRow, List<List<LocationNode>> locationNodes)
        {
            _locationNodes = locationNodes;
            _editColumnOrRow = editColumnOrRow;
            _mode = mode;

            for (int i = 0; i < index; i++)
            {
                _editColumnOrRow.ComboBox1.Items.Add(i);
            }

            _editColumnOrRow.GroupBox2.Text = text;

            Subscribe();
        }

        public int InsertAtIndex { get { return insertAtIndex;	} set { insertAtIndex = value; }	}

        private void Subscribe()
        {
            _editColumnOrRow.Accept += (e, o) =>
            {
                Accept();
            };
        }

        private void Accept()
        {
            if (_editColumnOrRow.ComboBox1.SelectedItem != null && _mode == 1)
            {
                insertAtIndex = (int)_editColumnOrRow.ComboBox1.SelectedItem;

                _editColumnOrRow.DialogResult = DialogResult.OK;
            }
            else if (_editColumnOrRow.ComboBox1.SelectedItem != null && _mode == 2)
            {
                if (_locationNodes[0].Count == 1)
                {
                    _editColumnOrRow.Label1.Visible = true;
                    _editColumnOrRow.Label1.Text = "You cannot remove any more columns.";
                }
                else
                {
                    insertAtIndex = (int)_editColumnOrRow.ComboBox1.SelectedItem;

                    _editColumnOrRow.DialogResult = DialogResult.OK;
                }
            }
            else if (_editColumnOrRow.ComboBox1.SelectedItem != null && _mode == 3)
            {
                if (_locationNodes.Count == 1)
                {
                    _editColumnOrRow.Label1.Visible = true;
                    _editColumnOrRow.Label1.Text = "You cannot remove any more rows.";
                }
                else
                {
                    insertAtIndex = (int)_editColumnOrRow.ComboBox1.SelectedItem;

                    _editColumnOrRow.DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
