using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public class RelationshipsComboboxPopulator
    {
        public void PopulateRelationshipsCmbBox(ComboBox comboBox, IVariables variables)
        {
            comboBox.Items.Clear();
            foreach(RelationshipUnit relationshipUnit in variables.Relations)
            {
                comboBox.Items.Add(relationshipUnit.TieName);
            }
        }
    }
}
