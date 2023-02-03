using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{    
    public class RelationshipUnit
    {
        string tieName;
        string oppositeTie;

        public RelationshipUnit() { }

        public RelationshipUnit(string tieName, string oppositeTie)
        {
            this.tieName = tieName;
            this.oppositeTie = oppositeTie;
        }

        public string TieName { get => tieName; set => tieName = value; }
        public string OppositeTie { get => oppositeTie; set => oppositeTie = value; }
    }
}
