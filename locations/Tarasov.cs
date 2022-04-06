using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Tarasov
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Tarasov Oil Field";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName);

                Merchant _temp = new Merchant($"{myName} Office");
                _temp.AddExportItem(new Listing(GameItem.Barrel_Crude, 20000));
                _temp.AddContract(new Contract(14, GameItem.Barrel_Crude, Romanovich.myName, 44800));
                _temp.AddContract(new Contract(11, GameItem.Barrel_Crude, Eastport.myName, 11000));
                _temp.AddContract(new Contract(31, GameItem.Barrel_Crude, Romanovich.myName, 99200));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);
            }

            return _myLoc;
        }
    }
}