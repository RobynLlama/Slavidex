using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class OasisForestry
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Oasis Forestry";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName);

                Merchant _temp = new Merchant("Lumber Yard Office");
                _temp.AddExportItem(new Listing(GameItem.Pallet_Log, 69000));
                _temp.AddContract(new Contract(2, GameItem.Pallet_Log, Balarsk.myName, 38000));             
                _temp.AddContract(new Contract(2, GameItem.Pallet_Log, Eastport.myName, 36000));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);
            }

            return _myLoc;
        }
    }
}