using Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RelationshipsValidator 
    {
        public List<Character> CalculateValidRelationships(ICharactersService charactersService, CharacterSheetPresenter characterSheetPresenter)
        {
            List<Character> result = new List<Character>();

            foreach (Character aCharacter in charactersService.Characters)
            {
                if (aCharacter.ID != characterSheetPresenter.Character.ID)
                {
                    if (characterSheetPresenter.FakeCharacter.Family.Count > 0)
                    {
                        bool addChar = true;

                        foreach (FamilyTieNode familyTie in characterSheetPresenter.FakeCharacter.Family)
                        {
                            if (aCharacter.ID == familyTie.Id)
                            {
                                addChar = false;
                            }
                        }

                        if (addChar == true)
                        {
                            result.Add(aCharacter);
                        }

                    }
                    else
                    {
                        result.Add(aCharacter);
                    }
                }
            }

            return result;
        }
    }
}
