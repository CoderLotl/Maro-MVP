using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Views;
using Main;
using Presenter;

namespace Presenters
{
    internal class CharacterSheetPresenter
    {
        //*************************************************
        Character character;
        Character fakeCharacter;
        int edited = 0;	// EDITED = 0: NO CHANGES WERE PERFORMED. EDITED = 1: CHANGES WERE PERFORMED BUT NOT CONFIRMED. EDITED = 2: CHANGES WERE EPRFORMED AND CONFIRMED.
        bool newCharacter;
        int initialized = 0;
        Image raceImage; Image genderImage; Image conditionImage; Image spConditionImage;

        readonly ICharacterSheet _iCharacterSheet;
        //*************************************************

        public CharacterSheetPresenter(ICharacterSheet frmCharacterSheet, MainPresenter mainPresenter, Character character, int option)
        {
            _iCharacterSheet = frmCharacterSheet;

            _iCharacterSheet.CharacterEventArgs = new Character(1);

            switch (option)
            {
                case 0: // VIEW
                    this.character = character;
                    break;
                case 1: // CREATE
                    this.newCharacter = true;
                    this.character = new Character(1);
                    break;
                case 2: // EDIT
                    this.character = character;
                    CopyCharacter(fakeCharacter, this.character);
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
            _iCharacterSheet.Undo += (e, o) =>
            {
                CopyCharacter(fakeCharacter, this.character);
            };

            _iCharacterSheet.EditCharData += (e, o) =>
            {
                CopyCharacter(this.character, o);
            };

            _iCharacterSheet.AddFamilyTie += (e, o) =>
            {
                AddFamilyNode(o);
            };

            _iCharacterSheet.RemoveFamilyTie += (e, o) =>
            {
                RemoveFamilyNode(o);
            };
        }

        private void CopyCharacter(Character copyTo_Character, Character copyFrom_Character)
        {
            copyTo_Character = new Character(copyFrom_Character.ID, copyFrom_Character.Name, copyFrom_Character.Age, copyFrom_Character.Race,
                                        copyFrom_Character.Gender, copyFrom_Character.Condition, copyFrom_Character.SpecialCondition);

            foreach (FamilyTieNode familyNode in copyFrom_Character.Family)
            {
                FamilyTieNode newNode = new FamilyTieNode(familyNode.Id, familyNode.Tie);
                copyTo_Character.Family.Add(newNode);
            }

            copyTo_Character.Description = copyFrom_Character.Description;
            copyTo_Character.IsAlive = copyFrom_Character.IsAlive;

            copyTo_Character.CharPicture = copyFrom_Character.CharPicture;

            copyTo_Character.Birthday = copyFrom_Character.Birthday;
            copyTo_Character.Deathday = copyFrom_Character.Deathday;
            copyTo_Character.Strength = copyFrom_Character.Strength;
            copyTo_Character.Melee = copyFrom_Character.Melee;
            copyTo_Character.Mining = copyFrom_Character.Mining;
            copyTo_Character.Harvesting = copyFrom_Character.Harvesting;
            copyTo_Character.Smithing = copyFrom_Character.Smithing;
            copyTo_Character.Dexterity = copyFrom_Character.Dexterity;
            copyTo_Character.Marksman = copyFrom_Character.Marksman;
            copyTo_Character.Ranching = copyFrom_Character.Ranching;
            copyTo_Character.Tailoring = copyTo_Character.Tailoring;
            copyTo_Character.Cooking = copyFrom_Character.Cooking;
            copyTo_Character.Knowledge = copyFrom_Character.Knowledge;
            copyTo_Character.Alchemy = copyFrom_Character.Alchemy;
            copyTo_Character.Engineering = copyFrom_Character.Engineering;
            copyTo_Character.Guile = copyFrom_Character.Guile;
            copyTo_Character.Manufacturing = copyFrom_Character.Manufacturing;            
        }

        private void AddFamilyNode(Character character)
        {
            FamilyTieNode node = new FamilyTieNode(character.ID);

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

            _iCharacterSheet.CharacterEventArgs = character;
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
    }
}
