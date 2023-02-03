using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Model
{
    public class CharactersService : ICharactersService
    {
        public CharactersService()
        {
            Characters = new List<Character>();
            ID = 0;
        }

        public List<Character> Characters { get; set ; }
        public int ID { get; set ; }

        public void LoadData()
        {
            JSONSerializer<List<Character>> jsonSerializer = new JSONSerializer<List<Character>>("Characters");
            Characters = jsonSerializer.DeSerialize();
            ID = Characters[Characters.Count - 1].ID;
        }

        public void SaveData()
        {
            JSONSerializer<List<Character>> jsonSerializer = new JSONSerializer<List<Character>>("Characters");

            jsonSerializer.Serialize(Characters);
        }

        public void RemoveChar(int index)
        {
            SyncCharsAtRemoval(Characters[index]);
            Characters.RemoveAt(index);
        }

        private void SyncCharsAtRemoval(Character charToRemove)
        {
            // THIS MAY LOOK TRIVIAL, BUT IT'S VERY IMPORTANT SINCE IT'S AN UPDATE. - NOT ALL CHANGES ARE PERFORMED AT THE CHAR SHEET
            // AND THIS IS ONE OF THOSE.
            foreach (Character character in Characters)
            {
                foreach (FamilyTieNode familyTieNode in character.Family)
                {
                    if (familyTieNode.Id == charToRemove.ID)
                    {
                        character.Family.Remove(familyTieNode);
                        break;
                    }
                }
            }
        }

        public void CalculateCharactersAge(Action<string> message)
        {
            CharactersAgeCalculator calculateCharactersAge = new CharactersAgeCalculator();
            calculateCharactersAge.CalcCharsAge(message, Characters);
        }
    }
}
