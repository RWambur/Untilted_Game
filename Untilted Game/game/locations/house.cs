using System;

namespace Untilted_Game
{
    public class LocationHouse
    {
        public static int count = 0;

        public static void House()
        {

            if (count == 1)
            {
                Console.WriteLine("Du stehst nun wieder in der Eingangstür der Holzhütte.");
                Commands.HouseDirCom();

            } else 
            {
                Console.WriteLine("Du betrittst das Haus und schaust dich im um.");
                Shortcuts.Enter();

                Console.WriteLine("Der Boden besteht aus Stein, Dachstützen hängen von der decke nieder\nund es riecht hier schrecklich verfault.");
                Shortcuts.Enter();

                Console.WriteLine("Du erkennst verschiedenes Mobiliar, alles sieht sehr in die Jahre gekommen aus, aber noch gesamt.");
                Shortcuts.Enter();

                Console.WriteLine("Ein Bett, ein Schrank, ein altes grünes Sofa und dazugehöriger Sofatisch ist zu erkennen.\nZudem sind an der hintersten Wand der alten Holzhütte zwei Türen.");
                Shortcuts.Enter();

                Console.WriteLine("Wo willst du zuerst hin?");
                Shortcuts.Tutorial.HouseDirTut();
                
                count = 1;
                Commands.HouseDirCom();
            }
            
            

        }
    }
}