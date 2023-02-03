/*
 * Created by SharpDevelop.
 * User: 107
 * Date: 14/01/2023
 * Time: 17:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
