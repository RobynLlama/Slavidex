namespace Slavidex.LocationsDB
{
    public static class Slaveria
    {

        //private static Location _myLoc;
        public static Location getLocation => fetch();

        public static string myName = "Slaveria";
        private static Location fetch()
        {
            return new Location(myName, $"{myName} is where it all happens and where the magic is at. If you are anywhere in the game world this is where you are.");
        }
    }
}