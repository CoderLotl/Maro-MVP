using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public interface IEditColumnOrRow
    {
        ComboBox ComboBox1 { get; set; }        
        Label Label1 { get; set; }
        GroupBox GroupBox2 { get; set; }
        DialogResult DialogResult { get; set; }

        event EventHandler Accept;
    }
}
