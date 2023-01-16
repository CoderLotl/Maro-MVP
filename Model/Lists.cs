using System.Collections.Generic;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Net;

namespace Library
{	
	public static class Lists
	{
//		private static int id;
//		private static string maroDateRaw;
//        private static string maroDate;
//        private static bool dateAcquired;
//        private static int year;
//        private static int day;
//        private static int hour;
//
//        private static List<Character> characters;
//		
//		public static List<Character> Characters {
//			set{	characters = value;		}	get{	return characters;		}
//		}
//		public static int ID {
//			set{	id = value;	}	get{	return id;	}
//		}
//
//        public static string MaroDate {
//        	get{ return maroDate;	} set{ maroDate = value; }
//        }
//        public static int Year {
//        	get{ return year;	} set{ year = value; }
//        }
//        public static int Day {
//			get{ return day;	} set{ day = value; }        	
//        }
//        public static int Hour {
//        	get{ return hour;	} set{ hour = value; }
//        }
//        public static bool DateAcquired {
//        	get{ return dateAcquired;	} set{ dateAcquired = value; }
//        }
//        public static void GenerateLists()
//		{
//			characters = new List<Character>();
//			id = 0;
//		}

        /// <summary>
        /// THIS HERE GETS CURRENT MAROSIA'S DATE.
        /// THE WAY IT OPERATES IS QUITE SIMPLE:
        /// 
        /// FIRST IT TRIES TO REACH WWW.MAROSIA.COM.
        /// IF IT SUCCEEDS, THEN IT PROCEEDS TO DOWNLOAD A COPY OF THE FRONT PAGE
        /// AS PLAIN TEXT, WHICH IT STORES.
        /// 
        /// THE METHOD "ProcessDate" PICKS THE STRING SAVED IN THE PREVIOUS STEP
        /// AND STARTS SPLITTING ITS CONTENT IN WORDS. WHENEVER IT FINDS THE WORD
        /// "Year" IT PARSES WHAT'S NEXT, STORING THE YEAR, DAY, AND HOUR.
        /// AFTER THAT IT STOPS AND THE PROCESS IS COMPLETE.
        /// 
        /// IF BY ANY CHANCE IT CAN'T REACH MAROSIA'S WEBPAGE, IT WILL SHOW A MESSAGE
        /// ON THE DATE LABEL.
        /// </summary>
//		public static void GetMaroDate()
//		{
//            try
//            {
//                maroDateRaw = Get("https://www.marosia.com/");
//                maroDate = ProcessDate(maroDateRaw, out year, out day, out hour);
//                dateAcquired = true;
//            }
//            catch
//            {
//                maroDate = "Couldn't get the game date. Check your connection!";
//                dateAcquired = false;
//            }
//        }

		/// <summary>
		/// THIS METHOD IS WHAT GETS THE COPY OF MARO'S FRONT PAGE.
		/// IT SENDS AN HTTP REQUEST, IDENTICAL TO A BROWSER TRYING TO LOAD THE PAGE,
		/// AND WHAT IT GETS IS THROWN TO THE STREAMREADER AND READED AS TEXT, WHICH IS THEN RETURNED.
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
//        private static string Get(string url)
//        {
//            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
//            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;            
//            
//            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
//            using (Stream stream = response.GetResponseStream())
//            using (StreamReader reader = new StreamReader(stream))
//            {
//                return reader.ReadToEnd();
//            }
//        }
//
//        private static string ProcessDate(string answer, out int year, out int day, out int hour)
//        {
//            year = 0;
//            day = 0;
//            hour = 0;
//            bool foundFlag = false;
//            int founds = 0;
//
//            foreach (string word in answer.Split(' '))
//            {
//                if (word == "Year")
//                {
//                    foundFlag = true;
//                }
//
//                if (foundFlag == true)
//                {
//                    int auxInt = 0;
//                    if (int.TryParse(word, out auxInt) == true)
//                    {
//                        switch (founds)
//                        {
//                            case 0:
//                                year = auxInt;
//                                founds++;
//                                break;
//                            case 1:
//                                day = auxInt;
//                                founds++;
//                                break;
//                            case 2:
//                                hour = auxInt;
//                                founds++;
//                                break;
//                        }
//                        if (founds == 3)
//                        {
//                            break;
//                        }
//                    }
//                }
//            }
//
//            return "Current Date: Year: " + year + " | Day: " + day + " | Hour: "+ hour;
//        }

    }
}
