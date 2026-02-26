using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDrink;
public static class CollectionExtention
{
	private const string TITLE_FORMAT_PREFIX = "--- ";
	private const string TITLE_FORMAT_SUFIX = " ---";
	private const string NULL_TEXT = "null";
public static void Print<T>(this IEnumerable<T>? list, string? title = null)
{
	if (title != null)
		Console.WriteLine(TITLE_FORMAT_PREFIX + title + TITLE_FORMAT_SUFIX);

	if (list == null)
	{
		Console.WriteLine(NULL_TEXT);
		return;
	}

	foreach (T item in list)
	{
		Console.WriteLine(item);
	}
	Console.WriteLine();
}
public static void Print<T>(this T? item, string? title = null)
	{
		if (title != null)
			Console.WriteLine(TITLE_FORMAT_PREFIX + title + TITLE_FORMAT_SUFIX);
		if (item == null)
		{
			Console.WriteLine(NULL_TEXT);
			Console.WriteLine();
			return;
		}
		Console.WriteLine(item);
		Console.WriteLine();
	}
}
