using System;
using Model;
using Presenter;

namespace Views
{

	public interface ICharacters
	{
		MainForm Main	{	get;	}
		
		string Lbl_Characters { set; }
				
		event EventHandler AddCharacter;
		event EventHandler<int> RemoveCharacter;
		event EventHandler LoadFile;
		event EventHandler SaveFile;
		event EventHandler Clear;
		event EventHandler UpdateAmountOfCharacters;
		event EventHandler<Action<string>> CalculateCharsAge;
	}
}
