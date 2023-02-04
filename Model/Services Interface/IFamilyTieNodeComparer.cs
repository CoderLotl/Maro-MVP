using System;

namespace Model
{
	public interface IFamilyTieNodeComparer
	{
		int GetHashCode(FamilyTieNode co);
		
		bool Equals(FamilyTieNode x1, FamilyTieNode x2);
	}
}
