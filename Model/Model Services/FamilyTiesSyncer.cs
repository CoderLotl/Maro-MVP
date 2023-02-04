using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FamilyTiesSyncer
    {
        public FamilyTiesSyncer()
        {

        }

        public void SyncFamilyTies(Character fakeCharacter, Character character, List<Character> characters)
        {
            // AT THIS POINT I ADD ANY FAMILY NODE THE FAKE CHAR GOT TO THE ORIGINAL CHAR.
            // THE MECHANIC IS THIS: EVERY NODE PRESENT IN THE ORIGINAL CHARACTER BUT ABSENT AT THE FAKE ONE ARE REMOVED FROM THE ORIGINAL.
            // THIS BECAUSE THE CHANGE MEANS THEY WERE REMOVED DURING THIS OPERATION.
            //
            // THE OPPOSITE HAPPENS WITH THE NODES PRESENT AT THE FAKE BUT ABSENT AT THE ORIGINAL. THEY ARE ADDED TO THE ORIGINAL CHARACTER.
            //
            // ALL THE AFFECTED CHARACTERS ARE SYNCED WITH THIS OPERATION.


            // --- UPDATING LISTS IN BOTH ORIGINAL CHAR AND ITS TIES

            foreach (FamilyTieNode originalFamilyTieNode in character.Family)
            {
                foreach (FamilyTieNode fakeFamilyNode in fakeCharacter.Family)
                {
                    if (originalFamilyTieNode.Id == fakeFamilyNode.Id && originalFamilyTieNode.Tie != fakeFamilyNode.Tie) // IF THERE'S A NODE THAT REPEATS BUT THE TIE IS CHANGED...
                    {
                        originalFamilyTieNode.Tie = fakeFamilyNode.Tie; // I UPDATE THE NODE.

                        foreach (Character aCharacter in characters) // THEN I GO FOR THE CHARACTER IT REFERS TO.
                        {
                            if (aCharacter.ID == originalFamilyTieNode.Id)
                            {
                                foreach (FamilyTieNode aFamilyNode in aCharacter.Family)
                                {
                                    if (aFamilyNode.Id == character.ID)
                                    {
                                        string opositeFamilyTie = "";
                                        switch (originalFamilyTieNode.Tie)
                                        {
                                            case "Parent":
                                                opositeFamilyTie = "Children";
                                                break;
                                            case "Children":
                                                opositeFamilyTie = "Parent";
                                                break;
                                            case "Spouse":
                                                opositeFamilyTie = "Spouse";
                                                break;
                                            case "Sibling":
                                                opositeFamilyTie = "Sibling";
                                                break;
                                        }

                                        aFamilyNode.Tie = opositeFamilyTie; // I DO THE SAME.
                                    }
                                }
                            }
                        }
                    }
                }
            }

            List<FamilyTieNode> nodesInFake = fakeCharacter.Family.Except(character.Family, new FamilyTieNodeComparer()).ToList();
            List<FamilyTieNode> nodesInOriginal = character.Family.Except(fakeCharacter.Family, new FamilyTieNodeComparer()).ToList();

            // NOTE !!!! : HERE I WAS GETTING AN ERROR FOR WHEN A CHARACTER WAS MARKED AS EDITTED BUT NO CHANGE WAS PERFORMED.
            // THE PROBLEM WAS THAT SINCE NODES ARE DIFFERENT YET THEY LOOK EQUAL, IN FACT BOTH FAMILY LISTS WERE CONSIDERED DIFFERENT AND SOME CHANGES
            // WERE WRITTEN WHEN NONE SHOULD HAVE BEEN WRITTEN. THIS LED TO A CRASH.
            //
            // I THEN IMPLEMENTED A NEW WAY TO COMPARE THE NODES OVERWRITTING THE EQUALS AND HASH WITH A NEW CLASS 'FamilyTieNodeComparer'.
            //
            // THIS WAS NOT ENOUGH, AS NODES WERE PERCEIVED AS DIFFERENT IF ONLY THE TIE TYPE CHANGED, SO FIRST I HAVE TO UPDATE THE ORIGINAL
            // CHAR'S FAMILY IF ANY MEMBER REPEATS BUT THEIR TIE CHANGES.

            // --- ADDING FAMILY NODES AND SCYNCING
            //
            // HERE I ONLY ADD NODES TO THE ORIGINAL CHAR AND THE CHARS THOSE NODES POINT TO.

            foreach (FamilyTieNode fakeFamilyNode in nodesInFake)
            {
                foreach (Character aCharacter in characters)
                {
                    if (aCharacter.ID == fakeFamilyNode.Id)
                    {
                        character.Family.Add(fakeFamilyNode);

                        string opositeFamilyTie = "";
                        switch (fakeFamilyNode.Tie)
                        {
                            case "Parent":
                                opositeFamilyTie = "Children";
                                break;
                            case "Children":
                                opositeFamilyTie = "Parent";
                                break;
                            case "Spouse":
                                opositeFamilyTie = "Spouse";
                                break;
                            case "Sibling":
                                opositeFamilyTie = "Sibling";
                                break;
                        }

                        FamilyTieNode newFamilyNode = new FamilyTieNode(character.ID, opositeFamilyTie);
                        aCharacter.Family.Add(newFamilyNode);
                    }
                }
            }

            // --- REMOVING FAMILY NODES AND SCYNCING
            //
            // HERE I ONLY REMOVE NODES FROM THE ORIGINAL CHAR AND FROM THOSE CHARS THE NODES POINT TO.

            foreach (FamilyTieNode originalFamilyNode in nodesInOriginal)
            {
                foreach (Character anotherChar in characters)
                {
                    if (anotherChar.ID == originalFamilyNode.Id)
                    {
                        character.Family.Remove(originalFamilyNode);

                        foreach (FamilyTieNode finalNode in anotherChar.Family) // here it crashes when i remove a node from a type of tie and add it to another
                        {                                                       // 12 hours later: it doesn't crash no more. Fixed it with adding the break.
                            if (finalNode.Id == character.ID)           // The problem was the initial size of the list changed with the removal of an object.
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
