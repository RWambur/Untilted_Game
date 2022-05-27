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
                Shortcuts.AvaliableCom.UseOpenTut();
                Com();
            } else if (comAns == "BACKPACK")
            {
                Inventory.Inv();
            } else if (comAns == "CLEAR")
            {
                Console.Clear();
                Com();
            } else
            {
                Shortcuts.Com.Error();
                Com();
            }
        }
        public static void ItemsCom()
        {
            string comAns = Console.ReadLine().ToUpper();

            if (comAns == "USE " + Inventory.content02)
            {
                if (Inventory.content02 == "LEER" )
                {
                    Shortcuts.NoMoreItems.NoMoreItem();
                    Com();
                } else
                {
                    Console.WriteLine("Du isst den Corny Müsliriegel und deine Gefühlswelt wird spürbar ein wenig milder.");
                    Inventory.content02 = Items.leer;
                }
            } else if (comAns == "HELP")
            {
                Shortcuts.AvaliableCom.UseItemTut();
                ItemsCom();
            } else if (comAns == "CLEAR")
            {
                Console.Clear();
                ItemsCom();
            } else
            {
                Shortcuts.Com.Error();
                ItemsCom();
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
                
            } else if (comDirAns == "BACKPACK")
            {
                Inventory.Inv();
                DirectionCom();
            } else if (comDirAns == "HELP")
            {
                Shortcuts.AvaliableCom.AvDirectionCom();
                DirectionCom();
            } else if (comDirAns == "CLEAR")
            {
                Console.Clear();
                ItemsCom();
            } else
            {
                Shortcuts.Com.Error();
                DirectionCom();
            }
        }
        public static void HouseDirCom()
        {
            string comAns = Console.ReadLine().ToUpper();

            if (comAns == "BETT")
            {
                Objects.Bed();
            } else if (comAns == "SCHRANK")
            {

            } else if (comAns == "SOFA")
            {

            } else if (comAns == "TÜR1")
            {

            } else if (comAns == "TÜR2")
            {
                
            } else if (comAns == "BACKPACK")
            {
                Inventory.Inv();
                HouseDirCom();
            } else if (comAns == "EXIT") 
            {
                Console.WriteLine("Du befindest dich wieder draußen, wo der Weg sich teilt.");
                Commands.DirectionCom();
            } else if (comAns == "HELP")
            {
                Shortcuts.AvaliableCom.AvHouseDirCom();
                HouseDirCom();
            } else if (comAns == "CLEAR")
            {
                Console.Clear();
                HouseDirCom();
            } else
            {
                Shortcuts.Com.Error();
                HouseDirCom();
            }
        }
    }
    public static class HouseObjCom
    {
        public static int count = 0;

        public static void BedCom()
        {
            string comAns = Console.ReadLine().ToUpper();
            

            if (comAns == "LOOK" && count == 0) 
            {
                Console.WriteLine("Du schaust dir das Bett an. Es ist ein altes Bett aus Holz mit verschiedenen Verschnörkelungen\nim Bettrahmen. Kissen, Bettdecke- und Bezug sind noch enthalten,");
                Shortcuts.Enter();

                Console.WriteLine("jedoch zerrissen und voller moß und fraglichen flecken.");
                Shortcuts.Enter();

                Console.WriteLine("Das Bett gibt ein total unangenehmen Geruch ab, der dich beinahe zum übergeben bringt,\nhättest du den Corny vorhin doch lieber essen sollen.");
                Shortcuts.Enter();

                count = 1;
            } else if (comAns == "LOOK" && count == 1)
            {
                Console.WriteLine("Du schaust dir das Bett noch einmal an, dir wird wieder übel, doch dann fällt dir etwas unter dem Bett auf.");
                Shortcuts.Enter();

                Console.WriteLine("Es ist eine Falltür!");
                count = 2;
                BedCom();

            } else if (comAns == "LOOK" && count == 2)
            {
                Console.WriteLine("Du hast dir bereits alles nenneswerte angeguckt.");
                BedCom();

            } else if (comAns == "BACK")
            {
                Console.WriteLine("Du stehts wieder an der Eingangstür.");
                Commands.HouseDirCom();
            } else if (comAns == "BACKPACK")
            {
                Inventory.Inv();
                BedCom();
            }
            else if (comAns == "HELP")
            {
                Shortcuts.AvaliableCom.AvBedCom();
                BedCom();
            } else if (comAns == "CLEAR")
            {
                Console.Clear();
                BedCom();
            } else
            {
                Shortcuts.Com.Error();
                BedCom();
            }
        }
    }
}