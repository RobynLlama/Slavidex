namespace Slavidex.LocationsDB
{
    public static class Jaceks
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Jacek's Place";
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