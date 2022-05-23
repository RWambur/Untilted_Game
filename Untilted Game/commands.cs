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
            Shortcuts shortcuts = new Shortcuts();

            if (comAns == "HELP")
            {
                Console.WriteLine("??");
                Com();

            } else if (comAns == "OPEN")
            {
                Inventory.Inv();
                
            } else if (comAns == "USE CORNY MÜSLIRIEGEL")
            {
                if (Inventory.content02 == "LEER" )
                {
                    Shortcuts.NoMoreItems.NoMoreCorny();
                    Com();
                } else 
                {
                    Inventory.content02 = Items.leer;
                    
                }

            } else if (comAns == "USE" + Inventory.content02)
            {
                Console.WriteLine(Inventory.content02);

            } else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nERROR\n");
                Console.ForegroundColor = ConsoleColor.White;
                Com();
            }
        }
    }
}