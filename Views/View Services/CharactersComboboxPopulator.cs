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
    public class CharactersComboboxPopulator
    {
        readonly ICharactersService _charactersService;
        readonly CharacterSheetPresenter _characterSheetPresenter;

        public CharactersComboboxPopulator(ICharactersService charactersService, CharacterSheetPresenter characterSheetPresenter)
        {
            _charactersService = charactersService;
            _characterSheetPresenter = characterSheetPresenter;
        }

        public void PopulateCharsCmbBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            RelationshipsValidator validRelationships = new RelationshipsValidator();

            foreach(Character character in validRelationships.CalculateValidRelationships(_charactersService, _characterSheetPresenter))
            {
                comboBox.Items.Add(character);
            }
        }
    }
}
