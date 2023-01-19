using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Date
    {
        string year;
        string day;
        string hour;

        public Date(string year, string day, string hour)
        {
            this.year = year;
            this.day = day;
            this.hour = hour;
        }

        public Date()
        {
			//EMPTY CONSTRUCTOR. NEEDED FOR SERIALIZATION.
        }

        public string Year {
        	get{ return year;	} set{ year = value; }
        }
        public string Day {
        	get{ return day;	} set{ day = value; }
        }
        public string Hour {
        	get{ return hour;	} set{ hour = value; }
        }
        
		public override string ToString()
		{
			return this.year + " / " + this.day + " / " + this.hour;
		}
    }
}
