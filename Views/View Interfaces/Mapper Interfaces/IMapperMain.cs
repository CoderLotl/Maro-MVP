using System;
using System.Windows.Forms;

namespace Views
{
	public interface IMapperMain
	{
		event EventHandler<string> UpdateTitle;
		
		string UITitle
		{
			get; set;
		}
		
	}
}
