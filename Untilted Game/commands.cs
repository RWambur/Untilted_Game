using System;

namespace Untilted_Game
{
    public class Commands
    {
        public static void Com()
        {
            string comAns = Console.ReadLine().ToUpper();
            Inventory inventory = new Inventory();
            Items items = new Items();

            switch (comAns)
            {
                case "HELP":
                    Console.WriteLine("??");
                    Com();
                    break;
                case "OPEN":
                    Inventory.Inv();
                    break;
                case "USE":
                    
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ERROR\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Com();
                    break;
            }
            
            
        }
    }
}