using System;

namespace Untilted_Game
{
    public class Locations
    {
        public static string Location;
        Shortcuts shortcuts = new Shortcuts();
        LocationGraveyard locationGraveyard = new LocationGraveyard();
        LocationHouse locationHouse = new LocationHouse();
        LocationLake locationlake = new LocationLake();
        LocationPathBegin locationpathbegin = new LocationPathBegin();
        LocationPathBehind locationpathbehind = new LocationPathBehind();
        LocationPlayground locationplayground = new LocationPlayground();

        public static void PathBegin()
        {
            Location = "Pathbegin";
            LocationPathBegin.PathBegin();
        }
        public static void House()
        {
            Location = "House";
            LocationHouse.House();
        }
        public static void Graveyard()
        {
            Location = "Graveyard";
            LocationGraveyard.Graveyard();
        }
        public static void Lake()
        {
            Location = "Lake";
            LocationLake.Lake();
        }
        public static void PathBehind()
        {
            Location = "Pathbehind";
            LocationPathBehind.PathBehind();
        }
        public static void Playground()
        {
            Location = "Playground";
            LocationPlayground.Playground();
        }
    }
}