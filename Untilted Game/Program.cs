using System;

namespace Untilted_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Untiteld Game";
            Console.ForegroundColor = ConsoleColor.White;
            Shortcuts shortcuts = new Shortcuts();

            Console.WriteLine("Durch skurrilen Websites im Internet erfuhrst du von einem verlassenen Ort,\nviele Menschen sollen dort ihr ableben gefunden haben.");
            Shortcuts.Tutorial.EnterTut();
            Shortcuts.Enter();

            Console.WriteLine("Es ist nicht klar was genau dort passiert ist,\nes gibt viele Spekulationen, jedoch keine definitive Antwort.");
            Shortcuts.Enter();

            Console.WriteLine("Nach stundenlangem lesen eines Forums über diesen Ort\nerfährst du nun endlich wo er sich befindet und machst dich bereit dorthin aufzubrechen.");
            Shortcuts.Enter();

            Console.WriteLine("Du packst dir deinen Rucksack, eine Kleinigkeit zu essen und gehst direkt los.");
            Shortcuts.Enter();

            Console.WriteLine("\n...");
            Shortcuts.Enter();

            Console.WriteLine("Eine weile verweilst du im Auto bevor du aussteigst,\nda dieser Ort in dir ein ein ungutes Gefühl erweckt, jedoch steigst du nun aus.");
            Shortcuts.Enter();

            Console.WriteLine("\n...");
            Shortcuts.Enter();

            Console.WriteLine("Wie im Forum schon stand siehst du einen verwachsenen Trampelpfad\nder dich zu einer alten vermoderten Holzhütte führen soll,");
            Shortcuts.Enter();

            Console.WriteLine("du gehst diesen Pfad entlang und trittst immer tiefer in den dunkele, fast schon, einengenden Wald.");
            Shortcuts.Enter();

            Console.WriteLine("Nach einer kleinen Ewigkeit kommst du nun endlich an die alte Holzhütte,");
            Shortcuts.Enter();

            Console.WriteLine("eigentlich wäre der Anblick einer kleinen Holzhütte in mitten eines Waldes etwas idyllisches,");
            Shortcuts.Enter();

            Console.WriteLine("jedoch spürst du einen kalten Schauer deinen rücken hinunter gleiten.");
            Shortcuts.Enter();

            Console.WriteLine("Um ein wenig die Fassung zu bewahren entscheidest du in deinen Rucksack\nzu greifen und den mitgebrachten Corny zu essen.");
            Shortcuts.Enter();

            Shortcuts.Tutorial.OpenTut();

            Inventory inventory = new Inventory();
            Items items = new Items();

            Inventory.content02 = Items.corny;

            Commands commands = new Commands();
            Commands.Com();

            Shortcuts.Tutorial.UseItemTut();
            
            Commands.Com();


            Shortcuts.Enter();

        }
    }
}
