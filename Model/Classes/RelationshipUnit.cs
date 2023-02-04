using System;
using System.Linq;

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

        public string TieName { get { return tieName; }	set { tieName = value; }	}
        public string OppositeTie { get { return oppositeTie; }	set { oppositeTie = value; }	}
    }
}
