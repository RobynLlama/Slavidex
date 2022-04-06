namespace Slavidex.LocationsDB
{
    public static class Stepanovich
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Stepanovich Coal Mine";
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