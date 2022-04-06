namespace Slavidex.LocationsDB
{
    public static class Dolgotov
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Dolgotov Saltflat";
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