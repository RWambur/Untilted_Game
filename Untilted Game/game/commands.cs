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

            } else if (comAns == "EINGANG")
            {

            } else if (comAns == "TÜR1")
            {

            } else if (comAns == "TÜR2")
            {
                
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
            } else if (comAns == "BACK")
            {

            } else 
            {
                Shortcuts.Com.Error();
                BedCom();
            }
        }
    }
}