using System;

namespace Untilted_Game 
{
    public class Debug 
    {
        public static void debug()
        {
            string comAns = Console.ReadLine().ToUpper();
            int count = 0;

            if (comAns == "LOOK" && count == 0) 
            {
                Console.WriteLine("0");
                count = 1;
                
            } else if (comAns == "LOOK" && count == 1)
            {
                Console.WriteLine("1");
                
            }
            debug();
        }
    }
}