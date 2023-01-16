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
		public CharactersPresenter(ICharacters iCharacters)
		{
			_iCharacters = iCharacters;
			
			
			iCharacters.LoadFile += (e, o) =>
			{
				LoadData();
				UpdateCharacterLabel();
			};
			
			iCharacters.SaveFile += (e, o) =>
			{
				
			};
			
			iCharacters.Clear += (e, o) =>
			{
				_iCharacters.Main.Presenter.Characters.Clear();
				UpdateCharacterLabel();
			};
		}
		
		//-----------------------------------------------------
		//------------------ [ METHODS ]
		//-----------------------------------------------------
		
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
//
//            DrawDataTable(1);
//
//            Lists.ID = Lists.Characters[Lists.Characters.Count - 1].ID;
//            UpdateInfo();
        }
		
		private void UpdateCharacterLabel()
		{
			_iCharacters.Lbl_Characters = _iCharacters.Main.Presenter.Characters.Count.ToString();
		}

	}
}
