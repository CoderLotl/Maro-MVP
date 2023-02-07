using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICharactersService
    {
        void SyncFamilyTies(Character fakeCharacter, Character character, List<Character> characters, IVariables variables);
        void SyncCharsAtRemoval(Character charToRemove, List<Character> characters);
        void CalcCharsAge(Action<string> message, List<Character> characters);
        List<Character> CalculateValidRelationships(ICharactersRepository charactersService, CharacterSheetPresenter characterSheetPresenter);
    }
}
