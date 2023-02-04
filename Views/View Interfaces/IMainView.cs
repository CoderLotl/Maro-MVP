using System;

namespace Views
{
	public interface IMainView
	{
		string Lbl_MaroDate { set; }
		
		event EventHandler RetrieveData;		
	}
}
