using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Presenter;

namespace Views
{
    public class FamilyComboboxPopulator
    {
        readonly MainPresenter _mainPresenter;
        readonly CharacterSheetPresenter _characterSheetPresenter;

        public FamilyComboboxPopulator(MainPresenter mainPresenter, CharacterSheetPresenter characterSheetPresenter)
        {
            _mainPresenter = mainPresenter;
            _characterSheetPresenter = characterSheetPresenter;
        }

        public void PopulateCharsCmbBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (Character aCharacter in _mainPresenter.Characters)
            {
                if (aCharacter.ID != _characterSheetPresenter.Character.ID)
                {
                    if (_characterSheetPresenter.FakeCharacter.Family.Count > 0)
                    {
                        bool addChar = true;

                        foreach (FamilyTieNode familyTie in _characterSheetPresenter.FakeCharacter.Family)
                        {
                            if (aCharacter.ID == familyTie.Id)
                            {
                                addChar = false;
                            }
                        }

                        if (addChar == true)
                        {
                            comboBox.Items.Add(aCharacter);
                        }

                    }
                    else
                    {
                        comboBox.Items.Add(aCharacter);
                    }
                }
            }
        }
    }
}
