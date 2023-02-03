using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Views
{
    public interface INewFamilyNodeView
    {
        event EventHandler<Control> PopulateCharactersComboBox;
        event EventHandler<Control> PopulateRelationshipsComboBox;
    }
}
