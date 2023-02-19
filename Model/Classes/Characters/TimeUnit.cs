
namespace Model
{
    public class TimeUnit
    {
        string year;
        string day;
        string hour;

        public TimeUnit(string year, string day, string hour)
        {
            this.year = year;
            this.day = day;
            this.hour = hour;
        }

        public TimeUnit()
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
