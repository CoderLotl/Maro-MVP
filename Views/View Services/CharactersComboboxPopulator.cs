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
        readonly ICharactersRepository _charactersRepository;
        readonly CharacterSheetPresenter _characterSheetPresenter;

        public CharactersComboboxPopulator(ICharactersRepository charactersRepository, CharacterSheetPresenter characterSheetPresenter)
        {
            _charactersRepository = charactersRepository;
            _characterSheetPresenter = characterSheetPresenter;
        }

        public void PopulateCharsCmbBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            CharactersService charactersService = new CharactersService();

            foreach(Character character in charactersService.CalculateValidRelationships(_charactersRepository, _characterSheetPresenter))
            {
                comboBox.Items.Add(character);
            }
        }
    }
}
