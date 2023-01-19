using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public interface ICharacterSheet
    {
        int Option { get; set;  }
        Character CharacterEventArgs { get; set; }
        string AuxString { get; set; }

        event EventHandler Undo;
        event EventHandler<Character> EditCharData;
        event EventHandler<Character> AddFamilyTie;
        event EventHandler<int> RemoveFamilyTie;
    }
}
