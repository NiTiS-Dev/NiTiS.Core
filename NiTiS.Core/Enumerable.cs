using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiTiS.Core;

public static partial class Enumerable
{
	public static T? Default<T>(this IEnumerable<T> enumerable)
		=> default;
}
