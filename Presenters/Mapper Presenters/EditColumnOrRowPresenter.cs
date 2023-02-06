using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presenter
{
    public class EditColumnOrRowPresenter
    {
        //*************************************************

        int insertAtIndex;
        int mode;
        List<List<LocationNode>> _locationNodes;
        IEditColumnOrRow _editColumnOrRow;

        //*************************************************

        public EditColumnOrRowPresenter(int index, string text, int mode, IEditColumnOrRow editColumnOrRow, List<List<LocationNode>> locationNodes)
        {
            _locationNodes = locationNodes;
            _editColumnOrRow = editColumnOrRow;

            for (int i = 0; i < index; i++)
            {
                _editColumnOrRow.ComboBox1.Items.Add(i);
            }

            _editColumnOrRow.GroupBox2.Text = text;

            Subscribe();
        }

        public int InsertAtIndex { get => insertAtIndex; set => insertAtIndex = value; }

        private void Subscribe()
        {
            _editColumnOrRow.Accept += (e, o) =>
            {
                Accept();
            };
        }

        private void Accept()
        {
            if (_editColumnOrRow.ComboBox1.SelectedItem != null && mode == 1)
            {
                insertAtIndex = (int)_editColumnOrRow.ComboBox1.SelectedItem;

                _editColumnOrRow.DialogResult = DialogResult.OK;
            }
            else if (_editColumnOrRow.ComboBox1.SelectedItem != null && mode == 2)
            {
                if (Data.LocationNodes[0].Count == 1)
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
            else if (_editColumnOrRow.ComboBox1.SelectedItem != null && mode == 3)
            {
                if (Data.LocationNodes.Count == 1)
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
