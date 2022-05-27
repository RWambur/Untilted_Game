using System;

namespace Untilted_Game
{
    public class Shortcuts
    {
        Commands commands = new Commands();

        public static void Enter()
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
        }
        public static void Name()
        {
            Console.Write("Name: ");
            Items.Name = Console.ReadLine();
            
            switch (Items.Name)
            {
                case "debug":
                    Debug.debug();
                    break;
                case "":
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Name();
                    break;
                default:
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    break;
            }
        }
        public static class Tutorial
        {
            public static void EnterTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("drücke ENTER um fortzufahren");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
            public static void HelpTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("gebe jederzeit HELP ein um die momentan möglichen Befehle aufzurufen");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void OpenTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("gebe BACKPACK ein um deinen Rucksack zu öffnen");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void UseItemTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("gebe USE ITEM ein um ein Item zu benutzen");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void DirectionTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("gebe RECHTS/LINKS/GERADE ein");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void HouseDirTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("gebe BETT/SCHRANK/SOFA/EINGANG/TÜR1/TÜR2/EXIT um dich zu bewegen");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void BackTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("gebe BACK ein um dich vom Bett abzuwenden");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void LookTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("gebe LOOK ein um dir das " + Objects.BedString + " anzuschauen");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static class NoMoreItems
        {
            public static void NoMoreItem()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Du besitzt keinen dieses Item nicht mehr.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static class Com
        {
            public static void Error()
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nERROR\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static class AvaliableCom
        {
            public static void UseOpenTut()
            {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("HELP - Zeigt momentan mögliche Befehle\nBACKPACK - Öffnet den Rucksack\nCLEAR - Löscht allen Inhalt der Console");
                    Console.ForegroundColor = ConsoleColor.White;
            }
            public static void UseItemTut()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("HELP - Zeigt momentan mögliche Befehle\nUSE ITEM - Nutzt ein Item, bspw 'use corny müsliriegel'\nCLEAR - Löscht allen Inhalt der Console");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void AvDirectionCom()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("HELP - Zeigt momentan mögliche Befehle\nCLEAR - Löscht allen Inhalt der Console\nRECHTS - gehst nach Rechts\nLINKS - gehst nach Link\nGERADE - gehst in die Holzhütte\nBACKPACK - Öffnet deinen Rucksack");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void AvHouseDirCom()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("HELP - Zeigt momentan mögliche Befehle\nCLEAR - Löscht allen Inhalt der Console\nBETT - gehst zum Bett\nSCHRANK - gehst zum Schrank\nSOFA - gehst zum Sofa\nTÜR1 - gehst zur ersten Tür an der hinteren Wand\nTÜR2 - gehst zur zwiten Tür an der hinteren Wand\nBACKPACK - Öffnet deinen Rucksack\nEXIT - du verlässt das Haus durch die Eingangstür");
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void AvBedCom()
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("HELP - Zeigt momentan mögliche Befehle\nCLEAR - Löscht allen Inhalt der Console\nLOOK - schaust dir das Object genauer an\nBACKPACK - Öffnet deinen Rucksack\nBACK - gehst zurück");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}