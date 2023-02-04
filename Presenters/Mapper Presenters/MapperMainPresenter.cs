using System;
using System.Collections.Generic;
using System.Data;
using Model;
using Views;

namespace Presenter
{
	public class MapperMainPresenter
	{
		//*************************************************
		
		DataTable DataDT;	
		int mapHeight;
		int mapWidht;
		string mapName;
		string title;
		bool savedFile;
		string filePath;
		static List<List<LocationNode>> locationNodes;
		IMapperMain _mapperMain;
				
		//*************************************************
		
		public MapperMainPresenter(IMapperMain mapperMain)
		{
			_mapperMain = mapperMain;
			title = "2D MoonNewt Mapper";

            InitializeData();
			DataDT = new DataTable();
			
			mapHeight = 100;
			mapWidht = 100;
			savedFile = false;			
		}
		
		//-------------------------------------------------------------------------------------
		
		private void Subscribe()
		{
			_mapperMain.UpdateTitle += (e, o) =>
			{				
				_mapperMain.UITitle = title + " * * * [ " + o + " ]";
			};
		}
		
		private void InitializeData()
		{
			locationNodes = new List<List<LocationNode>>();
			
			for(int i = 0; i < 5; i++)
			{
				List<LocationNode> listOfNodes = new List<LocationNode>();
				locationNodes.Add(listOfNodes);
				for (int j = 0; j < 5; j++)
				{
					LocationNode newNode = new LocationNode();
					PictureSerializer picSerializer = new PictureSerializer();

                    newNode.LocationImage = picSerializer.UploadImageAsString(global::Maro_MVP.Resources.tile_blank);

                    listOfNodes.Add(newNode);
				}
			}
		}
	}
}
