using System;

namespace Untilted_Game 
{
    public class Debug 
    {
        public static void debug()
        {
           
           Inventory.content02 = Items.corny;

           string comAns = Console.ReadLine().ToUpper();

            if (comAns == "USE " && Inventory.content02 != "LEER")
            {
                if (Inventory.content02 == "LEER" )
                {
                    Shortcuts.NoMoreItems.NoMoreCorny();
                    Commands.Com();

                } else 
                {
                    Console.WriteLine("Du isst den Corny Müsliriegel und deine Gefühlswelt wird spürbar ein wenig milder.");
                    Inventory.content02 = Items.leer;
                }
            } else
            {
                Shortcuts.Com.Error();
                Console.WriteLine(Inventory.content02);
                Commands.ItemsCom();
            }
        }
    }
}