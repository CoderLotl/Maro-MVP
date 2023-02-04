using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FamilyTieNodeComparer : IEqualityComparer<FamilyTieNode>, IFamilyTieNodeComparer
    {
        public int GetHashCode(FamilyTieNode co)
        {
            if (co == null)
            {
                return 0;
            }
            return co.Id.GetHashCode()+co.Tie.GetHashCode();
        }

        public bool Equals(FamilyTieNode x1, FamilyTieNode x2)
        {
            if (object.ReferenceEquals(x1, x2))
            {
                return true;
            }
            if (object.ReferenceEquals(x1, null) ||
                object.ReferenceEquals(x2, null))
            {
                return false;
            }
            return (x1.Id == x2.Id && x1.Tie == x2.Tie);
        }
    }
}
