using System;

namespace Untilted_Game
{
    public class Shortcuts
    {
        public static void Enter()
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        }
        public static class Tutorial
        {
            public static void EnterTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("drücke ENTER um fortzufahren....");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void OpenTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\ngeben OPEN ein um deinen Rucksack zu öffnen...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void UseItemTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("geben USE ITEM ein um ein Item zu benutzen...\n");
                Console.ForegroundColor = ConsoleColor.White;;
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
    }
}