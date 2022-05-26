using System;

namespace Untilted_Game
{
    public class Shortcuts
    {
        Commands commands = new Commands();

        public static void Enter()
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        }
        public static void Name()
        {
            Console.Write("Name: ");
            Items.Name = Console.ReadLine();
            
            switch (Items.Name)
            {
                case "debug":
                    Debug.debug();
                    break;
                case "":
                    Name();
                    break;
                default:
                    break;
            }
        }
        public static class Tutorial
        {
            public static void EnterTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("drücke ENTER um fortzufahren....");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
            public static void OpenTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\ngeben BACKPACK ein um deinen Rucksack zu öffnen...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void UseItemTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("geben USE ITEM ein um ein Item zu benutzen...\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void DirectionTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Gebe RECHTS/LINKS/GERADE ein");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void HouseDirTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Gebe BETT/SCHRANK/SOFA/EINGANG/TÜR1/TÜR2 um dich zu bewegen.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void BackTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Gebe BACK ein um dich vom Bett abzuwenden");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void LookTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Gebe LOOK ein um dir das " + Objects.BedString + " anzuschauen");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static class NoMoreItems
        {
            public static void NoMoreCorny()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Du besitzt keinen " + Items.corny + " mehr.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static class Com
        {
            public static void Error()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nERROR\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}