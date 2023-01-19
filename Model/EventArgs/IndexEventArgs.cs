using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class IndexEventArgs : EventArgs
    {
        public int index;

        public IndexEventArgs(int index)
        {
            this.index = index;
        }
    }
}
