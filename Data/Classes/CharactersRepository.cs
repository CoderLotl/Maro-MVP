using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Model
{
    public class CharactersRepository : ICharactersRepository
    {
        List<Character> characters;
        int id;        

        public CharactersRepository()
        {
            this.characters = new List<Character>();
            this.id = 0;            
        }

        public List<Character> Characters
        {
            get { return characters; }
            set { characters = value; }
        }
        public int ID
        {
            get { return id;    }
            set { id = value;   }
        }

        public void LoadData()
        {
            JSONSerializer<List<Character>> jsonSerializer = new JSONSerializer<List<Character>>("Characters", 1);
            Characters = jsonSerializer.DeSerialize();
            ID = Characters[Characters.Count - 1].ID;
        }

        public void SaveData()
        {
            JSONSerializer<List<Character>> jsonSerializer = new JSONSerializer<List<Character>>("Characters", 1);

            jsonSerializer.Serialize(Characters);
        }
        public void Add(Character entity)
        {
            Characters.Add(entity);
            ID++;
        }

        public void RemoveChar(int index)
        {
            CharactersService charactersService = new CharactersService();
            charactersService.SyncCharsAtRemoval(Characters[index], this.characters);
            Characters.RemoveAt(index);
        }


        public void CalculateCharactersAge(Action<string> message)
        {
            CharactersService charactersService = new CharactersService();
            charactersService.CalcCharsAge(message, Characters);
        }


        //public interface ICharactersRepository
        //{
        //    Characters GetById(int id);
        //    IEnumerable<Characters> GetAll();
        //    IEnumerable<Characters> GetWhere(Expression<Func<T, bool>> predicate);
        //    void Add(Characters entity);
        //    void Delete(Characters entity);
        //    void Edit(Characters entity);
        //    void SaveChanges();
        //}
    }
}
