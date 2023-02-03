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
        public void PopulateRelationshipsCmbBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach(var familyTie in Enum.GetNames(typeof(FamilyTie)))
            {
                comboBox.Items.Add(familyTie);
            }
        }
    }
}
