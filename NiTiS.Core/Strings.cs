using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiTiS.Core;

/// <summary>
/// Provides extensions for strings
/// </summary>
public static class Strings
{
	/// <summary>
	/// Repeat string X times
	/// </summary>
	/// <param name="value">String to repeat</param>
	/// <param name="repeat">Amount to repeat</param>
	/// <returns></returns>
	public static string Multiply(this string value, int repeat)
	{
		if (repeat <= 0)
		{
			return string.Empty;
		}
		return string.Concat(System.Linq.Enumerable.Repeat(value, repeat));
	}
	/// <summary>
	/// Creates string using some array
	/// </summary>
	/// <returns>For array {0, 1, 2 ,3} returns "[0, 1, 2, 3]"</returns>
	public static string FromArray<T>(T?[]? array, dToString<T>? dToString = null, string start = "[", string end = "]", string seperator = ", ", string nullName = "null")
	{
		StringBuilder sb = new();

		if (array is null)
			return string.Empty;

		sb.Append(start);
		for (int i = 0; i < array.Length; i++)
		{
			T? item = array[i];
			sb.Append((item is not null ? dToString is null? item.ToString() : dToString(item) : nullName) + ((array.Length - 1 == i) ? string.Empty : seperator));
		}
		sb.Append(end);

		return sb.ToString();
	}
	public static string FromArray(IEnumerable array, dToString? dToString = null, string start = "[", string end = "]", string seperator = ", ", string nullName = "null")
	{
		StringBuilder sb = new();

		if (array is null)
			return string.Empty;

		int count = 0;
		foreach (object _ in array) { count++; }

		int index = 0;
		sb.Append(start);
		foreach (object item in array)
		{
			sb.Append((item is not null ? dToString is null ? item.ToString() : dToString(item) : nullName) + ((count - 1 == index) ? string.Empty : seperator));
			index++;
		}
		sb.Append(end);

		return sb.ToString();
	}
	public static string FromArray<T>(IEnumerable<T> array, dToString<T>? dToString = null, string start = "[", string end = "]", string seperator = ", ", string nullName = "null")
	{
		StringBuilder sb = new();

		if (array is null)
			return string.Empty;

		int count = 0;
		foreach (object _ in array) { count++; }

		int index = 0;
		sb.Append(start);
		foreach (T item in array)
		{
			sb.Append((item is not null ? dToString is null ? item.ToString() : dToString(item) : nullName) + ((count - 1 == index) ? string.Empty : seperator));
			index++;
		}
		sb.Append(end);

		return sb.ToString();
	}
}