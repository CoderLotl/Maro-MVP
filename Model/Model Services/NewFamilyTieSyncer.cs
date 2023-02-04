using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class NewFamilyTiesSyncer : INewFamilyTieSyncer
    {
        public NewFamilyTiesSyncer()
        {

        }

        public void SyncFamilyTies(Character fakeCharacter, Character character, List<Character> characters, IVariables variables)
        {
            foreach (FamilyTieNode originalFamilyTieNode in character.Family)
            {
                foreach (FamilyTieNode fakeFamilyNode in fakeCharacter.Family)
                {
                    if (originalFamilyTieNode.Id == fakeFamilyNode.Id && originalFamilyTieNode.Tie != fakeFamilyNode.Tie)
                    {
                        originalFamilyTieNode.Tie = fakeFamilyNode.Tie;

                        foreach (Character aCharacter in characters)
                        {
                            if (aCharacter.ID == originalFamilyTieNode.Id)
                            {
                                foreach (FamilyTieNode aFamilyNode in aCharacter.Family)
                                {
                                    if (aFamilyNode.Id == character.ID)
                                    {
                                        string opositeFamilyTie = "";                                        
                                        foreach(RelationshipUnit tie in variables.Relations)
                                        {
                                        	if(tie.TieName == originalFamilyTieNode.Tie)
                                        	{
                                        		opositeFamilyTie = tie.OppositeTie;
                                        		break;
                                        	}
                                        }

                                        aFamilyNode.Tie = opositeFamilyTie;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            List<FamilyTieNode> nodesInFake = fakeCharacter.Family.Except(character.Family, new FamilyTieNodeComparer()).ToList();
            List<FamilyTieNode> nodesInOriginal = character.Family.Except(fakeCharacter.Family, new FamilyTieNodeComparer()).ToList();

            foreach (FamilyTieNode fakeFamilyNode in nodesInFake)
            {
                foreach (Character aCharacter in characters)
                {
                    if (aCharacter.ID == fakeFamilyNode.Id)
                    {
                        character.Family.Add(fakeFamilyNode);

                        string opositeFamilyTie = "";
						foreach(RelationshipUnit tie in variables.Relations)
						{
							if(tie.TieName == fakeFamilyNode.Tie)
							{
								opositeFamilyTie = tie.OppositeTie;
								break;
							}
						}

                        FamilyTieNode newFamilyNode = new FamilyTieNode(character.ID, opositeFamilyTie);
                        aCharacter.Family.Add(newFamilyNode);
                    }
                }
            }

            foreach (FamilyTieNode originalFamilyNode in nodesInOriginal)
            {
                foreach (Character anotherChar in characters)
                {
                    if (anotherChar.ID == originalFamilyNode.Id)
                    {
                        character.Family.Remove(originalFamilyNode);

                        foreach (FamilyTieNode finalNode in anotherChar.Family)
                        {
                            if (finalNode.Id == character.ID)
                            {
                                anotherChar.Family.Remove(finalNode);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
