using System;
using System.IO;
using System.Net;

namespace Model
{
	public class DateRetriever
	{
		public DateRetriever()
		{
		}
		
		public string GetMaroDate()
		{
			string maroDateRaw;			
            try
            {
                maroDateRaw = Get("https://www.marosia.com/");
                return ProcessDate(maroDateRaw);                
            }
            catch
            {
                return "Couldn't get the game date. Check your connection!";                
            }
        }
		
		private static string Get(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;            
            
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
		
		private string ProcessDate(string answer)
        {
            int year = 0;
            int day = 0;
            int hour = 0;
            bool foundFlag = false;
            int founds = 0;

            foreach (string word in answer.Split(' '))
            {
                if (word == "Year")
                {
                    foundFlag = true;
                }

                if (foundFlag == true)
                {
                    int auxInt = 0;
                    if (int.TryParse(word, out auxInt) == true)
                    {
                        switch (founds)
                        {
                            case 0:
                                year = auxInt;
                                founds++;
                                break;
                            case 1:
                                day = auxInt;
                                founds++;
                                break;
                            case 2:
                                hour = auxInt;
                                founds++;
                                break;
                        }
                        if (founds == 3)
                        {
                            break;
                        }
                    }
                }
            }
            
            if( foundFlag == true )
            {
            	return "Current Date: Year: " + year + " | Day: " + day + " | Hour: "+ hour;
            }
            else
            {
            	return "Couldn't get the game date. Check your connection!";
            }            
        }
	}
}
