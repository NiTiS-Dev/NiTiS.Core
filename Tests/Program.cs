using System;

namespace NiTiS.Core.Tests;

public static class Program
{
	public static void Main(string[] args)
	{
		Struct16 s1 = new();

		s1.LeftUInt8 = 1;

		Console.WriteLine(s1.UInt16);
		Console.WriteLine(s1.Boolean);
		Console.WriteLine(s1.LeftBoolean);
	}
}
