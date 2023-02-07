using System;
using System.Data;
using System.Collections.Generic;
using Model;
using Views;

namespace Presenter
{
	public class CharactersMainPresenter
	{
		//*************************************************	
		
		private readonly ICharactersMain _iCharacters;
		private readonly ICharactersRepository _charactersService;
        DataTable charsDT;
        DataView charsDTDV;
        
		//*************************************************	


        //-----------------------------------------------------
        //------------------ [ CONSTRUCTOR ]
        //-----------------------------------------------------
        public CharactersMainPresenter(ICharactersMain iCharacters, ICharactersRepository charactersService)
		{
			_iCharacters = iCharacters;
			_charactersService = charactersService;

			_iCharacters.RemoveCharacter += (e, o) =>	_charactersService.RemoveChar(o);
			
			_iCharacters.LoadFile += (e, o) =>
			{
				_charactersService.LoadData();
				UpdateCharacterLabel();
			};
			
			_iCharacters.SaveFile += (e, o) =>	_charactersService.SaveData();
			
			_iCharacters.Clear += (e, o) =>
			{
				_charactersService.Characters.Clear();
				UpdateCharacterLabel();
			};

			_iCharacters.UpdateAmountOfCharacters += (e, o) =>	UpdateCharacterLabel();

			_iCharacters.CalculateCharsAge += (e, o) =>	_charactersService.CalculateCharactersAge(o);
		}


        //-----------------------------------------------------
        //------------------ [ PROPERTIES ]
        //-----------------------------------------------------

        public DataTable CharsDT
        {
            get { return charsDT; }
            set { charsDT = value; }
        }

        public DataView CharsDTDV
        {
            get { return charsDTDV; }
            set { charsDTDV = value; }
        }

        //-----------------------------------------------------
        //------------------ [ METHODS ]
        //-----------------------------------------------------

        private void UpdateCharacterLabel()
		{
			_iCharacters.Lbl_Characters = _charactersService.Characters.Count.ToString();
		}
	}
}
