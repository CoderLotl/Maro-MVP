﻿using System;
using System.Collections.Generic;
using Views;
using Model;

namespace Presenter
{
	public class MainPresenter
	{
		//*************************************************	
		
		private readonly IMainView _iMainView;
		readonly public ICharactersService charactersService;
		string date;
		
		//*************************************************	
		
		public MainPresenter(IMainView iMainView)
		{
			_iMainView = iMainView;
			charactersService = new CharactersService();
			
			iMainView.RetrieveData += (o, e) =>
			{				
				DateRetriever retriever = new DateRetriever();
				date = retriever.GetMaroDate();
				Retrieve(date);
			};			
			
		}		

		//-----------------------------------------------------
		//------------------ [ METHODS ]
		//-----------------------------------------------------
		
		public void Retrieve(string date)
		{			
			_iMainView.Lbl_MaroDate = date;
		}
	}
}