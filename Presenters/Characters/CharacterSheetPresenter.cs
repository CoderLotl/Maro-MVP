using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Views;
using Presenter;
using System.Windows.Forms;

namespace Presenter
{
    public class CharacterSheetPresenter
    {
        //*************************************************
        Character character;
        Character fakeCharacter;
        int edited = 0;	// EDITED = 0: NO CHANGES WERE PERFORMED. EDITED = 1: CHANGES WERE PERFORMED BUT NOT CONFIRMED. EDITED = 2: CHANGES WERE EPRFORMED AND CONFIRMED.
        bool newCharacter;
        int initialized = 0;
        Image raceImage; Image genderImage; Image conditionImage; Image spConditionImage;
        readonly ICharactersRepository _characterService;
        readonly IVariables _variables;
        readonly ICharacterSheetView _iCharacterSheet;        
        //*************************************************

        public CharacterSheetPresenter(ICharacterSheetView frmCharacterSheet, ICharactersRepository charactersService, IVariables variables, Character character, int option)
        {
            _iCharacterSheet = frmCharacterSheet;
            _characterService = charactersService;
            _variables = variables;
            _iCharacterSheet.CharacterEventArgs = new Character(1);
            _iCharacterSheet.ProgressBarFiller = new ProgressBarFiller();

            switch (option)
            {
                case 0: // VIEW
                    this.character = character;
                    fakeCharacter = CopyCharacter(this.character);
                    break;
                case 1: // CREATE
                    this.newCharacter = true;
                    this.character = new Character(1);
                    this.character.ID = _characterService.ID + 1;
                    fakeCharacter = CopyCharacter(this.character);
                    break;
                case 2: // EDIT
                    this.character = character;
                    fakeCharacter = CopyCharacter(this.character);
                    break;
            }

            Subscribe();
        }

        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public Character Character
        {
            get { return character; }
            set { character = value; }
        }

        public Character FakeCharacter
        {
            get { return fakeCharacter; }
            set { fakeCharacter = value; }
        }

        //-----------------------------------------------------
        //------------------ [ METHODS ]
        //-----------------------------------------------------

        private void Subscribe()
        {
            _iCharacterSheet.Undo += (e, o) =>  fakeCharacter = CopyCharacter(this.character);

            _iCharacterSheet.EditCharData += (e, o) =>
            {
                CharactersService charactersService = new CharactersService();

                charactersService.SyncFamilyTies(fakeCharacter, character, _characterService.Characters, _variables);
                character = CopyCharacter(o);

                if(newCharacter == true)
                {                    
                    _characterService.Add(this.character);
                }
            };

            _iCharacterSheet.AddFamilyTie += (e, o) =>  AddFamilyNode(o);

            _iCharacterSheet.RemoveFamilyTie += (e, o) =>   RemoveFamilyNode(o);

            _iCharacterSheet.PopulateFamilyCombobox += (e, o) =>    PopulateFamilyCombobox(o);
        }

        private Character CopyCharacter(Character copyFrom_Character)
        {
            Character auxChar = new Character(copyFrom_Character.ID, copyFrom_Character.Name, copyFrom_Character.Age, copyFrom_Character.Race,
                                        copyFrom_Character.Gender, copyFrom_Character.Condition, copyFrom_Character.SpecialCondition);

            foreach (FamilyTieNode familyNode in copyFrom_Character.Family)
            {
                FamilyTieNode newNode = new FamilyTieNode(familyNode.Id, familyNode.Tie);
                auxChar.Family.Add(newNode);
            }

            auxChar.Description = copyFrom_Character.Description;
            auxChar.IsAlive = copyFrom_Character.IsAlive;

            auxChar.CharPicture = copyFrom_Character.CharPicture;

            auxChar.Birthday = copyFrom_Character.Birthday;
            auxChar.Deathday = copyFrom_Character.Deathday;
            auxChar.Strength = copyFrom_Character.Strength;
            auxChar.Melee = copyFrom_Character.Melee;
            auxChar.Mining = copyFrom_Character.Mining;
            auxChar.Harvesting = copyFrom_Character.Harvesting;
            auxChar.Smithing = copyFrom_Character.Smithing;
            auxChar.Dexterity = copyFrom_Character.Dexterity;
            auxChar.Marksman = copyFrom_Character.Marksman;
            auxChar.Ranching = copyFrom_Character.Ranching;
            auxChar.Tailoring = copyFrom_Character.Tailoring;
            auxChar.Cooking = copyFrom_Character.Cooking;
            auxChar.Knowledge = copyFrom_Character.Knowledge;
            auxChar.Alchemy = copyFrom_Character.Alchemy;
            auxChar.Engineering = copyFrom_Character.Engineering;
            auxChar.Guile = copyFrom_Character.Guile;
            auxChar.Manufacturing = copyFrom_Character.Manufacturing;

            return auxChar;
        }

        private void AddFamilyNode(FamilyTieNodeEventArgs familyTieNodeEventArgs)
        {
            FamilyTieNode node = new FamilyTieNode(familyTieNodeEventArgs.Character.ID, familyTieNodeEventArgs.Tie);

            //--------------------------------------------

            foreach (FamilyTieNode anotherNode in fakeCharacter.Family)
            {
                if (node.Id == anotherNode.Id)
                {
                    return; // IF THE CHAR IS ALREADY A FAMILY MEMBER, THIS EXITS THE OPERATION.
                }
            }

            //--------------------------------------------

            fakeCharacter.Family.Add(node); // OTHERWISE I ADD THE FAMILY NODE TO THE FAKE CHAR.            
        }

        private void RemoveFamilyNode(int index)
        {
            foreach (FamilyTieNode anotherFamilyTieNode in fakeCharacter.Family) // THEN I WORK WITH THIS CHAR. I CHECK THEIR FAMILY...
            {
                if (anotherFamilyTieNode.Id == index) // WHEN I FIND THE FAMILY NODE I'M REMOVING...
                {
                    fakeCharacter.Family.Remove(anotherFamilyTieNode); // I REMOVE IT, THAT'S IT!
                    break;
                }
            }
        }

        private void PopulateFamilyCombobox(ComboBox comboBox)
        {
            CharactersComboboxPopulator familyComboboxPopulator = new CharactersComboboxPopulator(_characterService, this);
            familyComboboxPopulator.PopulateCharsCmbBox(comboBox);
        }
    }
}
