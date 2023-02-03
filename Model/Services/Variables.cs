using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Variables
    {
        List<RelationshipUnit> _relations;
        Dictionary<int, string> _genders;
        Dictionary<int, string> _races;
        Dictionary<int, string> _conditions;
        Dictionary<int, string> _specialConditions;

        public Variables()
        {
            _relations = new List<RelationshipUnit>();
            _genders = new Dictionary<int, string>();
            _races = new Dictionary<int, string>();
            _conditions = new Dictionary<int, string>();
            _specialConditions = new Dictionary<int, string>();
        }

        public List<RelationshipUnit> Relations { get => _relations; set => _relations = value; }
        public Dictionary<int, string> Genders { get => _genders; set => _genders = value; }
        public Dictionary<int, string> Races { get => _races; set => _races = value; }
        public Dictionary<int, string> Conditions { get => _conditions; set => _conditions = value; }
        public Dictionary<int, string> SpecialConditions { get => _specialConditions; set => _specialConditions = value; }
    }
}
