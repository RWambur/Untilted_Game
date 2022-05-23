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
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Du besitzt keinen " + Items.corny + " mehr.");
                Console.ForegroundColor = ConsoleColor.White;
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
                Console.WriteLine("ERROR\n");
                Console.ForegroundColor = ConsoleColor.White;
                Com();
            }
            
            
        }
    }
}