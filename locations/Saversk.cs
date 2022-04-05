namespace Slavidex.LocationsDB
{
    public static class Saversk
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Saversk";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName);
            }

            return _myLoc;
        }
    }
}