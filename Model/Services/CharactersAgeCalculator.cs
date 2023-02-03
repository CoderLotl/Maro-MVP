using Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Model
{
    public class CharactersAgeCalculator
    {        
        string _date;
        int _year;
        int _day;

        public CharactersAgeCalculator()
        {            
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
                        int Year;
                        int Day;
                        if (int.TryParse(character.Birthday.Year, out Year) == true && int.TryParse(character.Birthday.Day, out Day) == true)
                        {
                            if (Year < _year && Day < _day)
                            {
                                character.Age = _year - Year;
                                calcPerformed = true;
                            }
                            if (Year < _year && Day > _day)
                            {
                                character.Age = _year - Year - 1;
                                calcPerformed = true;
                            }
                        }
                        else if (int.TryParse(character.Birthday.Year, out Year) == true)
                        {
                            if (Year < _year)
                            {
                                character.Age = _year - Year;
                                calcPerformed = true;
                            }
                        }
                    }
                }
            }
            if(calcPerformed == true)
            {
                message("All ages have been updated.");
            }
            else
            {
                message("Ages couldn't be updated. Check your connection!");
            }
        }

        private void ParseDate()
        {
            bool foundFlag = false;
            int founds = 0;

            foreach(string word in _date.Split(' '))
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
