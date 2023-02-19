using System;
using System.Collections.Generic;
using System.Linq;
using Presenter;

namespace Model
{
    public class CharactersService : ICharactersService
    {

        string _date;
        int _year;
        int _day;

        public CharactersService()
        {

        }

        public void SyncFamilyTies(Character fakeCharacter, Character character, List<Character> characters, IVariables variables)
        {
            foreach (FamilyTieNode originalFamilyTieNode in character.Family)
            {
                foreach (FamilyTieNode fakeFamilyNode in fakeCharacter.Family)
                {
                    if (originalFamilyTieNode.Id == fakeFamilyNode.Id && originalFamilyTieNode.Tie != fakeFamilyNode.Tie)
                    {
                        originalFamilyTieNode.Tie = fakeFamilyNode.Tie;

                        foreach (Character aCharacter in characters)
                        {
                            if (aCharacter.ID == originalFamilyTieNode.Id)
                            {
                                foreach (FamilyTieNode aFamilyNode in aCharacter.Family)
                                {
                                    if (aFamilyNode.Id == character.ID)
                                    {
                                        string opositeFamilyTie = "";
                                        foreach (RelationshipUnit tie in variables.Relations)
                                        {
                                            if (tie.TieName == originalFamilyTieNode.Tie)
                                            {
                                                opositeFamilyTie = tie.OppositeTie;
                                                break;
                                            }
                                        }

                                        aFamilyNode.Tie = opositeFamilyTie;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            List<FamilyTieNode> nodesInFake = fakeCharacter.Family.Except(character.Family, new FamilyTieNodeComparer()).ToList();
            List<FamilyTieNode> nodesInOriginal = character.Family.Except(fakeCharacter.Family, new FamilyTieNodeComparer()).ToList();

            foreach (FamilyTieNode fakeFamilyNode in nodesInFake)
            {
                foreach (Character aCharacter in characters)
                {
                    if (aCharacter.ID == fakeFamilyNode.Id)
                    {
                        character.Family.Add(fakeFamilyNode);

                        string opositeFamilyTie = "";
                        foreach (RelationshipUnit tie in variables.Relations)
                        {
                            if (tie.TieName == fakeFamilyNode.Tie)
                            {
                                opositeFamilyTie = tie.OppositeTie;
                                break;
                            }
                        }

                        FamilyTieNode newFamilyNode = new FamilyTieNode(character.ID, opositeFamilyTie);
                        aCharacter.Family.Add(newFamilyNode);
                    }
                }
            }

            foreach (FamilyTieNode originalFamilyNode in nodesInOriginal)
            {
                foreach (Character anotherChar in characters)
                {
                    if (anotherChar.ID == originalFamilyNode.Id)
                    {
                        character.Family.Remove(originalFamilyNode);

                        foreach (FamilyTieNode finalNode in anotherChar.Family)
                        {
                            if (finalNode.Id == character.ID)
                            {
                                anotherChar.Family.Remove(finalNode);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public List<Character> CalculateValidRelationships(ICharactersRepository charactersService, CharacterSheetPresenter characterSheetPresenter)
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

        public void SyncCharsAtRemoval(Character charToRemove, List<Character> characters)
        {
            // THIS MAY LOOK TRIVIAL, BUT IT'S VERY IMPORTANT SINCE IT'S AN UPDATE. - NOT ALL CHANGES ARE PERFORMED AT THE CHAR SHEET
            // AND THIS IS ONE OF THOSE.
            foreach (Character character in characters)
            {
                foreach (FamilyTieNode familyTieNode in character.Family)
                {
                    if (familyTieNode.Id == charToRemove.ID)
                    {
                        character.Family.Remove(familyTieNode);
                        break;
                    }
                }
            }
        }

        public void CalcCharsAge(Action<string> message, List<Character> characters)
        {
            DateRetriever dateRetriever = new DateRetriever();
            _date = dateRetriever.GetMaroDate();
            ParseDate();

            bool calcPerformed = false;

            foreach (Character character in characters)
            {
                if (character.IsAlive == true)
                {
                    if (character.Birthday != null)
                    {
                        int year = 0;
                        int day = 0;
                        bool longDate = false;
                        if (int.TryParse(character.Birthday.Year, out year) == true && int.TryParse(character.Birthday.Day, out day) == true)
                        {
                            longDate = true;
                            if (year < _year && day < _day)
                            {
                                character.Age = _year - year;
                                calcPerformed = true;
                            }
                            if (year < _year && day > _day)
                            {
                                character.Age = _year - year - 1;
                                calcPerformed = true;
                            }
                        }
                        else if (int.TryParse(character.Birthday.Year, out year) == true)
                        {
                            if (year < _year)
                            {
                                character.Age = _year - year;
                                calcPerformed = true;
                            }                            
                        }

                        AdjustAgeByTimeOuts(character, year, day, longDate);
                    }
                }
            }
            if (calcPerformed == true)
            {
                message("All ages have been updated.");
            }
            else
            {
                message("Ages couldn't be updated. Check your connection!");
            }
        }

        private void AdjustAgeByTimeOuts(Character character, int year, int day, bool longDate)
        {
            if (character.TimeOuts != null && character.TimeOuts.Count != 0)
            {
                int yearsToTake = 0;
                int daysToTake = 0;
                foreach (TimeUnit timeUnit in character.TimeOuts)
                {
                    int timeUnitYears = 0;
                    int timeUnitDays = 0;

                    int.TryParse(timeUnit.Year, out timeUnitYears);
                    int.TryParse(timeUnit.Day, out timeUnitDays);

                    yearsToTake += timeUnitYears;
                    daysToTake += timeUnitDays;

                    if (daysToTake >= 20)
                    {
                        daysToTake -= 20;
                        yearsToTake++;
                    }
                }

                if(longDate == true)
                {
                    if(Convert.ToInt32(character.Birthday.Day) < daysToTake)
                    {
                        character.Age -= (yearsToTake + 1);
                    }
                    else
                    {
                        character.Age -= yearsToTake;
                    }
                }
                else
                {
                    character.Age -= yearsToTake;
                }
            }
        }

        private void ParseDate()
        {
            bool foundFlag = false;
            int founds = 0;

            foreach (string word in _date.Split(' '))
            {
                if (word == "Year:")
                {
                    foundFlag = true;
                }

                if (foundFlag == true)
                {
                    int auxInt = 0;
                    if (int.TryParse(word, out auxInt) == true)
                    {
                        switch (founds)
                        {
                            case 0:
                                _year = auxInt;
                                founds++;
                                break;
                            case 1:
                                _day = auxInt;
                                founds++;
                                break;
                        }
                        if (founds == 2)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
