using System;
using System.Collections.Generic;

namespace Model
{
	public interface INewFamilyTieSyncer
	{
		void SyncFamilyTies(Character fakeCharacter, Character character, List<Character> characters, IVariables variables);
	}
}
