using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Drawing;

namespace Model
{	
		
	public class Character
	{
		// ----------------------------- ATTRIBUTES

		int id;
        string name;
        int age;		
		bool isAlive;		
		string description;
		Date birthday;
		Date deathday;
        string race;
		string gender;
		string condition;
		string specialCondition;
		string charPicture;

        // - - - FAMILY

        List<FamilyTieNode> family;

        // - - - STATS
        // SRENGTH
        int strength;
		int melee;
		int mining;
		int harvesting;
		int smithing;
		// DEXTERITY
		int dexterity;
		int marksman;
        int ranching;
        int tailoring;
		int cooking;
        // KNOWLEDGE
        int knowledge;
        int alchemy;
        int engineering;
        int guile;
        int manufacturing;


        // ----------------------------- SETTERS & GETTERS

        public int ID{
			set{	id = value;		}	get{	return id;		}
		}
		public string Description {
			get {	return description;	}set {	description = value;	}
		}
		public string Name{
			set{	name = value;	}	get{	return name;	}
		}
		public int Age{
			set{	age = value;	}	get{	return age;		}
		}
		public string Race{
			set{	race = value;	}	get{	return race;	}
		}
        public string Gender{
			set{	gender = value;	}	get{	return gender;	}
		}
		public string Condition{
			set{	condition = value;}	get{	return condition;}
		}
		public string SpecialCondition{
			set{	specialCondition = value;	}	get{	return specialCondition;	}
		}
		public bool IsAlive{
			set{	isAlive = value;	}	get { return isAlive; }
		}
		public string IsAliveStr{
			get{	if(isAlive == true){ return "Yes";	} else{	return "No";	}	}
		}		
		public int Strength{
			set{	strength = value;		}	get{	return strength;		}
		}
		public int Melee{
			set{	melee = value;		}	get{	return melee;		}
		}
		public int Mining{
			set{	mining = value;		}	get{	return mining;		}
		}
		public int Harvesting{
			set{	harvesting = value;		}	get{	return harvesting;		}
		}
		public int Smithing{
			set{	smithing = value;		}	get{	return smithing;		}
		}		
		public int Dexterity{
			set{	dexterity = value;		}	get{	return dexterity;		}
		}
		public int Marksman{
			set{	marksman = value;		}	get{	return marksman;		}
		}
		public int Ranching{
			set{	ranching = value;		}	get{	return ranching;		}
		}
		public int Tailoring{
			set{	tailoring = value;		}	get{	return tailoring;		}
		}
		public int Cooking{
			set{	cooking = value;		}	get{	return cooking;		}
		}
        public List<FamilyTieNode> Family{
        	get{ return family; } set{ family = value; }
        }
        public int Knowledge{
        	get{ return knowledge;	} set{ knowledge = value; }
        }
        public int Alchemy{
        	get{ return alchemy;	} set{ alchemy = value; }
        }
        public int Engineering{
        	get{ return engineering; }	set{ engineering = value; }
        }
        public int Guile{
        	get{ return guile;	} set{ guile = value; }
        }
        public int Manufacturing{
        	get{ return manufacturing;	} set{ manufacturing = value; }
        }
        public Date Birthday { 
        	get{ return birthday;	} set{ birthday = value; }
        }
        public Date Deathday {
			get{ return deathday;	} set{ deathday = value; }
        }

        public string CharPicture {
        	get{ return charPicture; 	}	set{ charPicture = value; }
        }


        // ----------------------------- CONSTRUCTOR

        public Character(int id, string name, int age, string race, string gender, string condition, string specialCondition){
			this.id = id;			
			this.name = name;
			this.age = age;
			this.race = race;
			this.gender = gender;
			this.condition = condition;
			this.specialCondition = specialCondition;
			this.charPicture = "";

			this.family = new List<FamilyTieNode>();

			this.birthday = new Date("--","--","--");
			this.deathday = new Date("--","--","--");

			this.strength = 0;
			this.melee = 0;
			this.mining = 0;
			this.harvesting = 0;
			this.smithing = 0;
			
			this.dexterity = 0;
			this.marksman = 0;
			this.ranching = 0;
			this.tailoring = 0;
			this.cooking = 0;

			this.knowledge = 0;
			this.alchemy = 0;
			this.engineering = 0;
			this.guile = 0;
			this.manufacturing = 0;
		}
		
		public Character()
		{
			//EMPTY CONSTRUCTOR. NEEDED FOR SERIALIZATION.
		}

		public Character(int filler)
		{
			this.id = 0;
			this.name = "fill this field";
			this.age = 0;
			this.birthday = new Date("--","--","--");
			this.deathday = new Date("--","--","--");
			this.isAlive = false;
			this.description = "";
			this.family = new List<FamilyTieNode>();
		}

		public override string ToString()
		{
			return String.Format("Name: {0,-20} | Race: {1,-10} | {2} years old.", this.Name, this.Race, this.Age);
		}

	}
}