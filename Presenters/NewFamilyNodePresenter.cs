using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;
using Model;
using Presenter;

namespace Presenters
{
    public class NewFamilyNodePresenter
    {
        readonly INewFamilyNodeView _newFamilyNodeView;
        readonly ICharactersService _charactersService;
        readonly CharacterSheetPresenter _characterSheetPresenter;
        FamilyTieNodeEventArgs eventArgs;

        public NewFamilyNodePresenter(INewFamilyNodeView newFamilyNodeView, ICharactersService charactersService, CharacterSheetPresenter characterSheetPresenter)
        {
            _newFamilyNodeView = newFamilyNodeView;
            _charactersService = charactersService;
            _characterSheetPresenter = characterSheetPresenter;
            eventArgs = new FamilyTieNodeEventArgs();

            Subscribe();
        }

        public FamilyTieNodeEventArgs EventArgs { get => eventArgs; set => eventArgs = value; }

        private void Subscribe()
        {
            _newFamilyNodeView.PopulateCharactersComboBox += (e, o) =>
            {
                CharactersComboboxPopulator familyComboboxPopulator = new CharactersComboboxPopulator(_charactersService, _characterSheetPresenter);
                familyComboboxPopulator.PopulateCharsCmbBox((ComboBox)o);
                
            };

            _newFamilyNodeView.PopulateRelationshipsComboBox += (e, o) =>
            {
                RelationshipsComboboxPopulator relationshipsComboboxPopulator = new RelationshipsComboboxPopulator();
                relationshipsComboboxPopulator.PopulateRelationshipsCmbBox((ComboBox)o);
            };
        }
        
    }
}
