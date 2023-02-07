using System;
using System.Windows.Forms;
using System.Linq;
using Views;
using Model;

namespace Presenter
{
    public class NewFamilyNodePresenter
    {
        readonly INewFamilyNodeView _newFamilyNodeView;
        readonly ICharactersRepository _charactersService;
        readonly IVariables _variables;
        readonly CharacterSheetPresenter _characterSheetPresenter;
        FamilyTieNodeEventArgs eventArgs;

        public NewFamilyNodePresenter(INewFamilyNodeView newFamilyNodeView, ICharactersRepository charactersService, IVariables variables, CharacterSheetPresenter characterSheetPresenter)
        {
            _newFamilyNodeView = newFamilyNodeView;
            _charactersService = charactersService;
            _variables = variables;
            _characterSheetPresenter = characterSheetPresenter;
            eventArgs = new FamilyTieNodeEventArgs();

            Subscribe();
        }

        public FamilyTieNodeEventArgs EventArgs { get {	return eventArgs; }	set { eventArgs = value; }	}

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
                relationshipsComboboxPopulator.PopulateRelationshipsCmbBox((ComboBox)o, _variables);
            };
        }
        
    }
}
