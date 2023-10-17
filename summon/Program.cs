// See https://aka.ms/new-console-template for more information


using summon.Models;
using System.Text;



Banner SumonExclusive = new Banner();

Unit p1 = new Unit("p", "3");
Unit p2 = new Unit("z", "3");
Unit p3 = new Unit("a", "3");
Unit p4 = new Unit("d", "4");
Unit p5 = new Unit("f", "4");
Unit p6 = new Unit("n", "4");
Unit p7 = new Unit("v", "5");


SumonExclusive.AddUnit(p1, p2, p3, p4, p5, p6, p7);
Console.OutputEncoding = Encoding.UTF8;
//SumonExclusive.UnitsList.ForEach(unit => {
//    Console.Write(unit.Name + " | " + unit.Rarity);
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write("🌟" + "\u263A");
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.WriteLine();
//});


SumonExclusive.StartSumon();


//SumonExclusive.SumonWithInterval();

