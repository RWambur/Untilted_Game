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
            Locations locations = new Locations();

            if (comAns == "HELP")
            {
                Console.WriteLine("??");
                Com();
            } else if (comAns == "BACKPACK")
            {
                Inventory.Inv();
            } else
            {
                Shortcuts.Com.Error();
            }
        }
        public static void ItemsCom()
        {
            string comAns = Console.ReadLine().ToUpper();

            if (comAns == "USE CORNY MÜSLIRIEGEL")
            {
                if (Inventory.content02 == "LEER" )
                {
                    Shortcuts.NoMoreItems.NoMoreCorny();
                    Com();

                } else 
                {
                    Console.WriteLine("Du isst den Corny Müsliriegel und deine Gefühlswelt wird spürbar ein wenig milder.");
                    Inventory.content02 = Items.leer;
                }
            } else
            {
                Shortcuts.Com.Error();
            }

        }
        public static void DirectionCom()
        {
            string comDirAns = Console.ReadLine().ToUpper();


            if (comDirAns == "RECHTS")
            {
                Locations.Lake();

            } else if (comDirAns == "LINKS")
            {
                Locations.Graveyard();

            } else if (comDirAns == "GERADE")
            {
                Locations.House();
                
            } else 
            {
                Shortcuts.Com.Error();
            }
        }
    }
}