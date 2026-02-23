using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDogsAndCircles;
public class EvenBetterObjectComparer
{
	public T Largest<T>(T a, T b, T c, IComparer<T> comparer)
	{
		if (comparer.Compare(a,b) > 0)
		{
			return comparer.Compare(a, c) > 0 ? a : c;
		}

		return comparer.Compare(b, c) > 0 ? b : c;
	}
	public T Largest<T> (T a, T b, T c) where T : IComparable<T>
	{
		if (a.CompareTo(b) > 0)
		{
			return a.CompareTo(c) > 0 ? a : c;
		}

		return b.CompareTo(c) > 0 ? b : c;
	}
}
