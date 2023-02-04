using System;
using System.Collections.Generic;

namespace Model
{
	public interface ICharactersAgeCalculator
	{
		void CalcCharsAge(Action<string> message, List<Character> characters);
	}
}
