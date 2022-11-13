using NiTiS.Core.Maths;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NiTiS.Core.Tests;

public static class Program
{
	public static void Main(string[] args)
	{
		string w2 = Strings.FromArray((IEnumerable)new object[] { 1, 2, 3 }, (object i) => (~(int)i).ToString(), "!", "A");
		string w = typeof(IOrderedEnumerable<IEnumerable<(int, double)>>).NormalizedFullName(true);
		Console.WriteLine(w);
		Console.WriteLine(w2);
	}
}
