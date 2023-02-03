using System;

namespace Model
{
	public enum FamilyTie
	{
		Parent,
		Sibling,
		Spouse,
		Children,
	}
	
	public enum Race{
		Folk,
		Avian,
		Therian,
		Golem,
		Daemon,
		Naga,
		Fae,
		Kobold,
		Unknown,
		Deity,
		Beast,		
	}
	
	public enum Gender{
		Male,
		Female,
		Unknown,
	}
	
	public enum Condition{
		Normal,
		Sanguine,
		Undead,
		Cursed,		
	}
	
	public enum SpecialCondition{
		None,
		Avatar,
	}
}
