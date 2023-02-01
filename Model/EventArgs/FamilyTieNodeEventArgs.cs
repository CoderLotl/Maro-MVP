using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FamilyTieNodeEventArgs : EventArgs
    {
        Character character;
        string tie;

        public FamilyTieNodeEventArgs(Character character, string tie)
        {
            this.character = character;
            this.tie = tie;
        }

        public Character Character { get { return character; }	set { character = value; }	}
        public string Tie { get { return tie; }	set { tie = value; }	}
    }
}
