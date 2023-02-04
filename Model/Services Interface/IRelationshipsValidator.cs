using System;
using System.Collections.Generic;
using System.Linq;
using Presenter;
using System.Threading.Tasks;

namespace Model
{
    public interface IRelationshipsValidator
    {
    	List<Character> CalculateValidRelationships(ICharactersService charactersService, CharacterSheetPresenter characterSheetPresenter);
    }
}
