using System;
using System.Data;
using System.Collections.Generic;
using Model;
using Views;

namespace Presenter
{
	public class CharactersPresenter
	{
		//*************************************************	
		
		private readonly ICharacters _iCharacters;
        DataTable charsDT;
        DataView charsDTDV;
        
		//*************************************************	
		
        //-----------------------------------------------------
		//------------------ [ PROPERTIES ]
		//-----------------------------------------------------
		
		public DataTable CharsDT
		{
			get {	return charsDT;	}
			set {	charsDT = value;	}
		}
		
		public DataView CharsDTDV
		{
			get {	return charsDTDV;	}
			set {	charsDTDV = value;	}
		}

        //-----------------------------------------------------
        //------------------ [ CONSTRUCTOR ]
        //-----------------------------------------------------
        public CharactersPresenter(ICharacters iCharacters)
		{
			_iCharacters = iCharacters;

			iCharacters.RemoveCharacter += (e, o) =>
			{
				RemoveChar((IndexEventArgs)o);
			};
			
			iCharacters.LoadFile += (e, o) =>
			{
				LoadData();
				UpdateCharacterLabel();
			};
			
			iCharacters.SaveFile += (e, o) =>
			{
				SaveData();
			};
			
			iCharacters.Clear += (e, o) =>
			{
				_iCharacters.Main.Presenter.Characters.Clear();
				UpdateCharacterLabel();
			};

			iCharacters.UpdateAmountOfCharacters += (e, o) =>
			{
				UpdateCharacterLabel();
			};
		}

		//-----------------------------------------------------
		//------------------ [ METHODS ]
		//-----------------------------------------------------

		private void RemoveChar(IndexEventArgs index)
		{
			SyncCharsAtRemoval(_iCharacters.Main.Presenter.Characters[index.index]);
			_iCharacters.Main.Presenter.Characters.RemoveAt(index.index);
		}

		private void SaveData()
		{
			JSONSerializer<List<Character>> jsonSerializer = new JSONSerializer<List<Character>>("Characters");

			jsonSerializer.Serialize(_iCharacters.Main.Presenter.Characters);
		}
		
		private void LoadData()
        {
            _iCharacters.Main.Presenter.Characters.Clear();

            JSONSerializer<List<Character>> jsonSerializer = new JSONSerializer<List<Character>>("Characters");

            _iCharacters.Main.Presenter.Characters = jsonSerializer.DeSerialize();

			_iCharacters.Main.Presenter.ID = _iCharacters.Main.Presenter.Characters[_iCharacters.Main.Presenter.Characters.Count - 1].ID;
        }
		
		private void UpdateCharacterLabel()
		{
			_iCharacters.Lbl_Characters = _iCharacters.Main.Presenter.Characters.Count.ToString();
		}

        private void SyncCharsAtRemoval(Character charToRemove)
		{
            // THIS MAY LOOK TRIVIAL, BUT IT'S VERY IMPORTANT SINCE IT'S AN UPDATE. - NOT ALL CHANGES ARE PERFORMED AT THE CHAR SHEET
            // AND THIS IS ONE OF THOSE.
            foreach (Character character in _iCharacters.Main.Presenter.Characters)
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

	}
}
