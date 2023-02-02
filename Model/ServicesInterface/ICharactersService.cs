using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ICharactersService
    {
        List<Character> Characters { get; set;  }
        int ID { get; set; }

        void LoadData();
        void RemoveChar(int index);
        void CalculateCharactersAge(Action<string> message);
        void SaveData();
    }
}
