using System;
using System.Drawing;

namespace Model
{
	public class LocationNode
	{
		int x;
		int y;
		string locationName;
		string locationImage;
		string description;
		string locationType;
		
		public LocationNode()
		{
			
		}

		public string LocationImage
		{
			get {	return locationImage;	}	set {	locationImage = value;	}
		}
		
		public string LocationName
		{
			get {	return locationName;	}	set {	locationName = value;	}
		}
		
		public string Description
		{
			get {	return description;	}	set {	description = value;	}
		}

		public string LocationType
		{
			get { 	return locationType; }	set { locationType = value;	}
		}

		public int Y
		{
			get {	return y;	}	set {	y = value;	}
		}

		public int X
		{
			get {	return x;	}	set {	x = value;	}
		}

    }
}
