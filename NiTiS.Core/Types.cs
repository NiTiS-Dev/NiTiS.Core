using System;
using System.Text;

namespace NiTiS.Core;

public static class Types
{
	public static string NormalizedName(this Type type, bool deepFullName = false)
		=> NormalizedNameBuild(type, deepFullName).ToString();
	public static string NormalizedFullName(this Type type, bool deepFullName = true)
		=> NormalizedFullNameBuild(type, deepFullName).ToString();
	private static StringBuilder NormalizedNameBuild(this Type type, bool deepFullName)
	{
		StringBuilder sb = new();

		if (type.IsGenericType)
		{
			sb.Append(type.Name.Substring(0, type.Name.IndexOf('`')));
			sb.Append(Strings.FromArray(type.GenericTypeArguments, (Type t) => (deepFullName ? t.NormalizedFullNameBuild(deepFullName) : t.NormalizedNameBuild(deepFullName)).ToString(), "<", ">"));
			return sb;
		}
		else
			return sb.Append(type.Name);
	}
	private static StringBuilder NormalizedFullNameBuild(this Type type, bool deepFullName)
	{
		StringBuilder sb = new();
		sb.Append(type.Namespace);
		sb.Append('.');
		sb.Append(NormalizedNameBuild(type, deepFullName));
		return sb;
	}
}