using EFCRosBil;
using Microsoft.EntityFrameworkCore;

// 1) Opret et context-objekt

using RosBilDBContext context = new RosBilDBContext();


//foreach (var obj in context.Set<Kunde>())
//{
//	Console.WriteLine(obj);
//}
//Console.WriteLine();

//foreach (var obj in context.Set<Bil>())
//{
//	Console.WriteLine(obj);
//}
//Console.WriteLine();

foreach (var obj in context.Set<Leje>().Include(l => l.Bil).Include(l => l.Kunde))
{
	Console.WriteLine(obj);
}
Console.WriteLine();

