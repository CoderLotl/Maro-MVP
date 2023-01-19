using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class FamilyTieNode
    {
        int id;
        string tie;

        public FamilyTieNode(int id, string tie)
        {
            this.id = id;
            this.tie = tie;
        }

        public FamilyTieNode(int id)
        {
            this.id = id;
            this.tie = "";
        }

        public FamilyTieNode()
        {
			//EMPTY CONSTRUCTOR. NEEDED FOR SERIALIZATION.
        }

        public int Id{
        	get{ return id; }	set{ id = value; }
        }
        public string Tie {
        	get{ return tie;	} set{ tie = value; }
        }
    }
}
