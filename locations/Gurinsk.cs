namespace Slavidex.LocationsDB
{
    public static class Gurinsk
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Gurinsk";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName, $"{myName} is the location all players start at in The {Slaveria.myName}n Trucker. There are some items scattered about both inside and outside the house. Check out back for a Christmas surprise.");
            }

            return _myLoc;
        }
    }
}