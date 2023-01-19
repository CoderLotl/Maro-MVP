//using System.Drawing;
//using System.Windows.Forms;
//using System;
//using Framework.Controls;
//using System.Xml;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization;
//using Main.Properties;
//using Library;
//using System.Collections.Generic;

//namespace Main
//{
//	public static class Utilities
//	{
//        //-----------------------------------------------------
//        //------------------ [ MISCELANEOUS ]
//        //-----------------------------------------------------

//        public static Color BttnColorChange(Control sender, Color colorparam)
//		{			
//			Color originalColor = sender.BackColor;        	
//        	sender.BackColor = colorparam;
        	
//        	return originalColor;
//		}
		
//		public static void ProgressBarFiller(XpProgressBar control, string text, int number)
//		{
//			string level = "";
//			int maximum = 0;
			
			
//			if(number <= 99)
//			{
//				if( text == "Strength" || text == "Dexterity" || text == "Knowledge")
//				{
//					level = "Weak";
//				}
//				else
//				{
//					level = "Poor";
//				}
//				maximum = 0;
//			}
//			else if(number <= 199)
//			{
//				if( text == "Strength" || text == "Dexterity" || text == "Knowledge")
//				{					
//					level = "Okay";
//				}
//				else
//				{
//					level = "Novice";
//				}
//				maximum = 100;
//			}
//			else if(number <= 299)
//			{
//				if( text == "Strength" || text == "Dexterity" || text == "Knowledge")
//				{					
//					level = "Average";
//				}
//				else
//				{
//					level = "Apprentice";
//				}
//				maximum = 200;
//			}
//			else if(number <= 399)
//			{
//				if( text == "Strength" || text == "Dexterity" || text == "Knowledge")
//				{					
//					level = "Good";
//				}
//				else
//				{
//					level = "Expert";
//				}
//				maximum = 300;
//			}
//			else
//			{
//				if( text == "Strength" || text == "Dexterity" || text == "Knowledge")
//				{					
//					level = "Strong";
//				}
//				else
//				{
//					level = "Master";
//				}
//				maximum = 400;
//			}
			
//			control.Text = text+": "+level;			
//			control.Position = number - maximum;
//		}

//        //-----------------------------------------------------
//        //------------------ [ DATA MANAGEMENT ]
//        //-----------------------------------------------------

//        public static void RaceImagePicker(string race, Control control, Image raceImage)
//        {
//            switch (race)
//            {
//                case "Folk":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_folk_icon");
//                    break;
//                case "Avian":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_avian_icon");
//                    break;
//                case "Therian":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_therian_icon");
//                    break;
//                case "Golem":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_golem_icon");
//                    break;
//                case "Daemon":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_daemon_icon");
//                    break;
//                case "Naga":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_naga_icon");
//                    break;
//                case "Fae":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_fae_icon");
//                    break;
//                case "Kobold":
//                    raceImage = (Image)Resources.ResourceManager.GetObject("marosia_kobold_icon");
//                    break;
//                default:
//                    raceImage = (Image)Resources.ResourceManager.GetObject("unknown");
//                    break;
//            }

//            control.BackgroundImage = raceImage;
//        }

//        //-----------------------------------------------------
//        //------------------ [ IMAGE PICKERS ]
//        //-----------------------------------------------------

//        public static void GenderImagePicker(string gender, Control control, Image genderImage)
//		{
//			switch (gender)
//			{
//				case "Male":
//					genderImage = (Image)Resources.ResourceManager.GetObject("mars");
//					break;
//				case "Female":
//					genderImage = (Image)Resources.ResourceManager.GetObject("venus");
//					break;
//				case "Unknown":
//                    genderImage = (Image)Resources.ResourceManager.GetObject("third_gender");
//                    break;
//            }

//			control.BackgroundImage = genderImage;
//		}

//		public static void ConditionImagePicker(string condition, Control control, Image conditionImage)
//		{
//			switch (condition)
//			{
//				case "Normal":
//					conditionImage = (Image)Resources.ResourceManager.GetObject("normal");
//					break;
//				case "Sanguine":
//					conditionImage = (Image)Resources.ResourceManager.GetObject("marosia_sanguine_icon");
//					break;
//				case "Undead":
//                    conditionImage = (Image)Resources.ResourceManager.GetObject("hand");
//                    break;
//				case "Cursed":
//					conditionImage = (Image)Resources.ResourceManager.GetObject("voodoo_doll");
//                    break;
//            }

//			control.BackgroundImage = conditionImage;
//		}

//		public static void SpConditionImagePicker(string spCondition, Control control, Image spConditionImage)
//		{
//			switch (spCondition)
//			{
//				case "None":
//					spConditionImage = (Image)Resources.ResourceManager.GetObject("person");
//					break;
//				case "Avatar":
//					spConditionImage = (Image)Resources.ResourceManager.GetObject("god");
//					break;
//            }

//			control.BackgroundImage = spConditionImage;
//		}

//        //-----------------------------------------------------
//        //------------------ [ LOGIC ]
//        //-----------------------------------------------------
        
//        public static void AssignFakeValuesToOriginal(Character fakeCharacter, Character originalCharacter)
//		{
//            originalCharacter.CharPicture = fakeCharacter.CharPicture;

//            originalCharacter.Name = fakeCharacter.Name;
//            originalCharacter.Age = fakeCharacter.Age;
//            originalCharacter.Race = fakeCharacter.Race;
//            originalCharacter.Gender = fakeCharacter.Gender;
//            originalCharacter.Condition = fakeCharacter.Condition;
//            originalCharacter.SpecialCondition = fakeCharacter.SpecialCondition;
//            originalCharacter.Description = fakeCharacter.Description;

//            originalCharacter.IsAlive = fakeCharacter.IsAlive;
            
//            originalCharacter.Birthday = fakeCharacter.Birthday;
//            originalCharacter.Deathday = fakeCharacter.Deathday;

//            originalCharacter.Strength = fakeCharacter.Strength;
//            originalCharacter.Melee = fakeCharacter.Melee;
//            originalCharacter.Mining = fakeCharacter.Mining;
//            originalCharacter.Harvesting = fakeCharacter.Harvesting;
//            originalCharacter.Smithing = fakeCharacter.Smithing;

//            originalCharacter.Dexterity = fakeCharacter.Dexterity;
//            originalCharacter.Marksman = fakeCharacter.Marksman;
//            originalCharacter.Ranching = fakeCharacter.Ranching;
//            originalCharacter.Tailoring = fakeCharacter.Tailoring;
//            originalCharacter.Cooking = fakeCharacter.Cooking;

//            originalCharacter.Knowledge = fakeCharacter.Knowledge;
//            originalCharacter.Alchemy = fakeCharacter.Alchemy;
//            originalCharacter.Engineering = fakeCharacter.Engineering;
//            originalCharacter.Guile = fakeCharacter.Guile;
//            originalCharacter.Manufacturing = fakeCharacter.Manufacturing;
//        }
        
//        public static void CalcCharsAge(Action<string> message)
//        {
//        	if(Lists.DateAcquired == true)
//        	{
//        		foreach(Character character in Lists.Characters)
//        		{           				
//        			if(character.IsAlive == true)
//        			{
//						if(character.Birthday != null)
//        				{
//        					int Year;
//        					int Day;
//        					if(int.TryParse(character.Birthday.Year, out Year) == true && int.TryParse(character.Birthday.Day, out Day) == true)
//        					{
//        						if(Year < Lists.Year && Day < Lists.Day)
//        						{
//        							character.Age = Lists.Year - Year;
//        						}
//        						if(Year < Lists.Year && Day > Lists.Day)
//        						{
//        							character.Age = Lists.Year - Year - 1;
//        						}
//        					}
//        					else if(int.TryParse(character.Birthday.Year, out Year) == true)
//        					{
//								if(Year < Lists.Year)
//        						{
//        							character.Age = Lists.Year - Year;
//        						}
//        					}
//        				}
//        			}        			
//        		}
//        		message("All ages have been updated.");
//        	}
//        	else
//        	{
//        		message("Ages couldn't be updated. Check your connection!");	
//        	}        	
//        }

//		public static void SyncFamilyTies(Character fakeCharacter, Character character)
//		{
//            // AT THIS POINT I ADD ANY FAMILY NODE THE FAKE CHAR GOT TO THE ORIGINAL CHAR.
//            // THE MECHANIC IS THIS: EVERY NODE PRESENT IN THE ORIGINAL CHARACTER BUT ABSENT AT THE FAKE ONE ARE REMOVED FROM THE ORIGINAL.
//            // THIS BECAUSE THE CHANGE MEANS THEY WERE REMOVED DURING THIS OPERATION.
//            //
//            // THE OPPOSITE HAPPENS WITH THE NODES PRESENT AT THE FAKE BUT ABSENT AT THE ORIGINAL. THEY ARE ADDED TO THE ORIGINAL CHARACTER.
//            //
//            // ALL THE AFFECTED CHARACTERS ARE SYNCED WITH THIS OPERATION.


//            // --- UPDATING LISTS IN BOTH ORIGINAL CHAR AND ITS TIES

//            foreach (FamilyTieNode originalFamilyTieNode in character.Family)
//            {
//                foreach (FamilyTieNode fakeFamilyNode in fakeCharacter.Family)
//                {
//                    if (originalFamilyTieNode.Id == fakeFamilyNode.Id && originalFamilyTieNode.Tie != fakeFamilyNode.Tie) // IF THERE'S A NODE THAT REPEATS BUT THE TIE IS CHANGED...
//                    {
//                        originalFamilyTieNode.Tie = fakeFamilyNode.Tie; // I UPDATE THE NODE.

//                        foreach (Character aCharacter in Lists.Characters) // THEN I GO FOR THE CHARACTER IT REFERS TO.
//                        {
//                            if (aCharacter.ID == originalFamilyTieNode.Id)
//                            {
//                                foreach (FamilyTieNode aFamilyNode in aCharacter.Family)
//                                {
//                                    if (aFamilyNode.Id == character.ID)
//                                    {
//                                        string opositeFamilyTie = "";
//                                        switch (originalFamilyTieNode.Tie)
//                                        {
//                                            case "Parents":
//                                                opositeFamilyTie = "Children";
//                                                break;
//                                            case "Children":
//                                                opositeFamilyTie = "Parents";
//                                                break;
//                                            case "Spouses":
//                                                opositeFamilyTie = "Spouses";
//                                                break;
//                                            case "Siblings":
//                                                opositeFamilyTie = "Siblings";
//                                                break;
//                                        }

//                                        aFamilyNode.Tie = opositeFamilyTie; // I DO THE SAME.
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }

//            List<FamilyTieNode> nodesInFake = fakeCharacter.Family.Except(character.Family, new FamilyTieNodeComparer()).ToList();
//            List<FamilyTieNode> nodesInOriginal = character.Family.Except(fakeCharacter.Family, new FamilyTieNodeComparer()).ToList();

//            // NOTE !!!! : HERE I WAS GETTING AN ERROR FOR WHEN A CHARACTER WAS MARKED AS EDITTED BUT NO CHANGE WAS PERFORMED.
//            // THE PROBLEM WAS THAT SINCE NODES ARE DIFFERENT YET THEY LOOK EQUAL, IN FACT BOTH FAMILY LISTS WERE CONSIDERED DIFFERENT AND SOME CHANGES
//            // WERE WRITTEN WHEN NONE SHOULD HAVE BEEN WRITTEN. THIS LED TO A CRASH.
//            //
//            // I THEN IMPLEMENTED A NEW WAY TO COMPARE THE NODES OVERWRITTING THE EQUALS AND HASH WITH A NEW CLASS 'FamilyTieNodeComparer'.
//            //
//            // THIS WAS NOT ENOUGH, AS NODES WERE PERCEIVED AS DIFFERENT IF ONLY THE TIE TYPE CHANGED, SO FIRST I HAVE TO UPDATE THE ORIGINAL
//            // CHAR'S FAMILY IF ANY MEMBER REPEATS BUT THEIR TIE CHANGES.

//            // --- ADDING FAMILY NODES AND SCYNCING
//            //
//            // HERE I ONLY ADD NODES TO THE ORIGINAL CHAR AND THE CHARS THOSE NODES POINT TO.

//            foreach (FamilyTieNode fakeFamilyNode in nodesInFake)
//            {
//                foreach (Character aCharacter in Lists.Characters)
//                {
//                    if (aCharacter.ID == fakeFamilyNode.Id)
//                    {
//                        character.Family.Add(fakeFamilyNode);

//                        string opositeFamilyTie = "";
//                        switch (fakeFamilyNode.Tie)
//                        {
//                            case "Parents":
//                                opositeFamilyTie = "Children";
//                                break;
//                            case "Children":
//                                opositeFamilyTie = "Parents";
//                                break;
//                            case "Spouses":
//                                opositeFamilyTie = "Spouses";
//                                break;
//                            case "Siblings":
//                                opositeFamilyTie = "Siblings";
//                                break;
//                        }

//                        FamilyTieNode newFamilyNode = new FamilyTieNode(character.ID, opositeFamilyTie);
//                        aCharacter.Family.Add(newFamilyNode);
//                    }
//                }
//            }

//            // --- REMOVING FAMILY NODES AND SCYNCING
//            //
//            // HERE I ONLY REMOVE NODES FROM THE ORIGINAL CHAR AND FROM THOSE CHARS THE NODES POINT TO.

//            foreach (FamilyTieNode originalFamilyNode in nodesInOriginal)
//            {
//                foreach (Character anotherChar in Lists.Characters)
//                {
//                    if (anotherChar.ID == originalFamilyNode.Id)
//                    {
//                        character.Family.Remove(originalFamilyNode);

//                        foreach (FamilyTieNode finalNode in anotherChar.Family) // here it crashes when i remove a node from a type of tie and add it to another
//                        {                                                       // 12 hours later: it doesn't crash no more. Fixed it with adding the break.
//                            if (finalNode.Id == character.ID)           // The problem was the initial size of the list changed with the removal of an object.
//                            {
//                                anotherChar.Family.Remove(finalNode);
//                                break;
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
