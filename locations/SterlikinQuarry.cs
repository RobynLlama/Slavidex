using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class SterlikinQuarry
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Sterlikin Quarry";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName, $"{myName} is the premier rock excavation and extraction facility in {Slaveria.myName}. The materials exported here see use primarily in concrete and cement manufacturing plants.");

                Merchant _temp = new Merchant("Quarry Foreman's Office");
                _temp.AddContract(new Contract(25, GameItem.Sack_Stone, Lupova.myName, 45000));
                _temp.AddContract(new Contract(30, GameItem.Sack_Stone, Eastport.myName, 33600));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Rock Crusher");
                _temp.AddExportItem(new Listing (GameItem.Sack_Stone, 2000));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);
            }

            return _myLoc;
        }
    }
}