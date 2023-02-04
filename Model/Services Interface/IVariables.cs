using System;
using System.Collections.Generic;

namespace Model
{
	public interface IVariables
	{
		void LoadVariables();
		
		List<RelationshipUnit> Relations { get; set; }
		List<string> Genders { get; set; }
		List<string> Races { get; set; }
		List<string> Conditions { get; set; }
		List<string> SpecialConditions { get; set; }
	}
}
