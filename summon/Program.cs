// See https://aka.ms/new-console-template for more information


using summon.Models;
using System.Text;
//using PersonalTimer = System.Timers;

//PersonalTimer.Timer aTimer;

//aTimer = new PersonalTimer.Timer();
//aTimer.Interval = 2000;

//aTimer.Elapsed += OnTimedEvent;


//aTimer.AutoReset = true;


//aTimer.Enabled = true;

//Console.WriteLine("Press the Enter key to exit the program at any time... ");
//Console.ReadLine();


//void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
//{
//    Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
//}




Unit Ten = new Unit("Ten", "3");
Unit Bulma = new Unit("Bulma", "3");
Unit Freezer = new Unit("Freezer", "3");
Unit KameS = new Unit("KameS", "3");
Unit Vegeta = new Unit("Vegeta", "4");
Unit Krillin = new Unit("Krillin", "4");
Unit Yamcha = new Unit("Yamcha", "4");
Unit SonGoku = new Unit("Son Goku", "5");

Banner SumonExclusive = new Banner();
SumonExclusive.AddUnit(Ten, Bulma, Freezer, KameS, Vegeta, Krillin, Yamcha, SonGoku);
Console.OutputEncoding = Encoding.UTF8;
//SumonExclusive.UnitsList.ForEach(unit => {
//    Console.Write(unit.Name + " | " + unit.Rarity);
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write("🌟" + "\u263A");
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.WriteLine();
//});

SumonExclusive.StartSumon();



