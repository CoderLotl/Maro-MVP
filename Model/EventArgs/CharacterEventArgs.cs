using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CharacterEventArgs : EventArgs
    {
        Character character;

        public CharacterEventArgs()
        {
            this.character = new Character(1);
        }

        public Character Character { get => character; set => character = value; }
    }
}
