using System;

namespace Untilted_Game
{
    public class Inventory
    {
        public static string content01 = "LEER";
        public static string content02 = "LEER";
        public static string content03 = "LEER";
        public static string content04 = "LEER";
        public static string content05 = "LEER";
        public static string content06 = "LEER";
        public static string content07 = "LEER";
        public static string content08 = "LEER";
        public static string content09 = "LEER";
        public static string content10 = "LEER";
        
        public static void Inv()
        {

            Console.WriteLine("\nInhalt:");
            Console.WriteLine("1. " + content01);
            Console.WriteLine("2. " + content02);
            Console.WriteLine("3. " + content03);
            Console.WriteLine("4. " + content04);
            Console.WriteLine("5. " + content05);
            Console.WriteLine("6. " + content06);
            Console.WriteLine("7. " + content07);
            Console.WriteLine("8. " + content08);
            Console.WriteLine("9. " + content09);
            Console.WriteLine("10. " + content10 + "\n");
        }
    }
}