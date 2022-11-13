using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiTiS.Core;

public static partial class Enumerable
{
	public static IEnumerable<TSource> SkipLast<TSource>(this IEnumerable<TSource> enumerable, int count)
	{
		int size = 0;
		foreach (TSource i in enumerable)
		{
			size++;
		}
		foreach (TSource i in enumerable)
		{
			if (size-- - count == 0) yield break;
			yield return i;
		}
	}
}