using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace Model
{
	public static class Data
	{
		static List<List<LocationNode>> locationNodes;
		
		public static void InitializeData()
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

		public static List<List<LocationNode>> LocationNodes
		{
			get {	return locationNodes;	}	set {	locationNodes = value;	}
		}
	}
}
