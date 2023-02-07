using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICharactersRepository
    {
        List<Character> Characters { get; set;  }
        int ID { get; set; }

        void LoadData();
        void RemoveChar(int index);
        void CalculateCharactersAge(Action<string> message);
        void SaveData();
        void Add(Character entity);

        //    Characters GetById(int id);
        //    IEnumerable<Characters> GetAll();
        //    IEnumerable<Characters> GetWhere(Expression<Func<T, bool>> predicate);
        //    void Delete(Characters entity);
        //    void Edit(Characters entity);
        //    void SaveChanges();
    }
}
