using System;

namespace Untilted_Game
{
    public class Objects
    {   
        public static string BedString = "Bett";

        public static void Bed()
        {
            Console.WriteLine("Du bewegst dich zum Bett.");
            Console.WriteLine("Was nun?");
            Shortcuts.Tutorial.LookTut();
            HouseObjCom.BedCom();

            Console.WriteLine("Was nun?");
            Shortcuts.Tutorial.BackTut();
            HouseObjCom.BedCom();

            Console.WriteLine("End");
        }
    }
}