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
		event EventHandler LoadFile;
		event EventHandler SaveFile;
		event EventHandler Clear;		
	}
}
