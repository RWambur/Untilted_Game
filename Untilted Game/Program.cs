using System;

namespace Untilted_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Untiteld Game";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Durch skurrilen Websites im Internet erfuhrst du von einem verlassenen Ort,\nviele Menschen sollen dort ihr ableben gefunden haben.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("drücke ENTER um fortzufahren...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            Console.WriteLine("Es ist nicht klar was genau dort passiert ist,\nes gibt viele Spekulationen, jedoch keine definitive Antwort.");
            Console.ReadKey();

            Console.WriteLine("Nach stundenlangem lesen eines Forums über diesen Ort\nerfährst du nun endlich wo er sich befindet und machst dich bereit dorthin aufzubrechen.");
            Console.ReadKey();

            Console.WriteLine("Du packst dir deinen Rucksack, eine Kleinigkeit zu essen und gehst direkt los.");
            Console.ReadKey();

            Console.WriteLine("\n...");
            Console.ReadKey();

            Console.WriteLine("Eine weile verweilst du im Auto bevor du aussteigst,\nda dieser Ort in dir ein ein ungutes Gefühl erweckt, jedoch steigst du nun aus.");
            Console.ReadKey();

            Console.WriteLine("\n...");
            Console.ReadKey();

            Console.WriteLine("Wie im Forum schon stand siehst du einen verwachsenen Trampelpfad\nder dich zu einer alten vermoderten Holzhütte führen soll,");
            Console.ReadKey();

            Console.WriteLine("du gehst diesen Pfad entlang und trittst immer tiefer in den dunkele, fast schon, einengenden Wald.");
            Console.ReadKey();

            Console.WriteLine("Nach einer kleinen Ewigkeit kommst du nun endlich an die alte Holzhütte,");
            Console.ReadKey();

            Console.WriteLine("eigentlich wäre der Anblick einer kleinen Holzhütte in mitten eines Waldes etwas idyllisches,");
            Console.ReadKey();

            Console.WriteLine("jedoch spürst du einen kalten Schauer deinen rücken hinunter gleiten.");
            Console.ReadKey();

            Console.WriteLine("Um ein wenig die Fassung zu bewahren entscheidest du in deinen Rucksack\nzu greifen und den mitgebrachten Corny zu essen.");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("geben OPEN ein um deinen Rucksack zu öffnen...\n");
            Console.ForegroundColor = ConsoleColor.White;

            Inventory inventory = new Inventory();
            Items items = new Items();

            Inventory.content02 = Items.corny;

            Commands commands = new Commands();
            Commands.Com();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("geben USE ITEM ein um ein Item zu benutzen...\n");
            Console.ForegroundColor = ConsoleColor.White;;

            /*Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("gebe jederzeit HELP ein um alle befehle noch einmal anzuschauen.\n");
            Console.ForegroundColor = ConsoleColor.White;*/
            
            Commands.Com();

            Console.ReadKey();

        }
    }
}
