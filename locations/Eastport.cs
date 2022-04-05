using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Eastport
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Eastport";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName, $"{myName} is the final destination for many goods and contracts in {Slaveria.myName}. Notable for being only a stone's throw from {Kolovy.myName}\nThere are no goods or commerce here, only delivery areas for contracts.");
            }

            return _myLoc;
        }
    }
}