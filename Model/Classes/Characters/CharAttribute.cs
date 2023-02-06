using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CharAttribute
    {
        private string attribute;
        private int points;

        public CharAttribute(string attribute, int points)
        {
            this.attribute = attribute;
            this.points = points;
        }

        public CharAttribute()
        {
            //EMPTY CONSTRUCTOR NEEDED FOR SERIALIZATION
        }

        public string Attribute { get{ return attribute;	} set{ attribute = value; } }
        public int Points { get{  return points;	} set{ points = value; }	}
    }
}
