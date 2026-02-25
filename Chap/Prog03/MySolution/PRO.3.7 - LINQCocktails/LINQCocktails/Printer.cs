using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQCocktails;
public static class Printer
{
	private const string PREFIX = "----- ", SUFFIX = " -----";
	public static void Print<T>(this IEnumerable<T> values, string title)
	{
		Console.WriteLine(PREFIX + title + SUFFIX);
		foreach (var item in values)
		{
			Console.WriteLine(item);
		}
		Console.WriteLine();
	}
	public static void Print<T>(this T value, string title)
	{
		Console.WriteLine(PREFIX + title + SUFFIX);
		Console.WriteLine(value);
		Console.WriteLine();
	}
	public static void Title(string title)
	{
		Console.WriteLine(PREFIX + title + SUFFIX);
	}
}
