using System;

namespace Untilted_Game 
{
    public class Debug 
    {
        public static void debug()
        {
           
           Inventory.content02 = Items.corny;

           string comAns = Console.ReadLine().ToUpper();

            if (comAns == "USE " + Inventory.content02)
            {
                if (Inventory.content02 == "LEER" )
                {
                    Shortcuts.NoMoreItems.NoMoreItem();
                    Commands.Com();

                } else 
                {
                    Console.WriteLine("Du isst den Corny Müsliriegel und deine Gefühlswelt wird spürbar ein wenig milder.");
                    Inventory.content02 = Items.leer;
                    Console.WriteLine(Inventory.content02);

                }
            } else
            {
                Shortcuts.Com.Error();
                debug();
            }
        }
    }
}