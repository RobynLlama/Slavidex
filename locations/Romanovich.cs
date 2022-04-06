using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Romanovich
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Romanovich Oil Refinery";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName);

                Merchant _temp = new Merchant($"Refinery Loading Dock");
                _temp.AddImportItem(new Listing(GameItem.Barrel_Crude, 27500));
                _temp.AddImportItem(new Listing(GameItem.Barrel_Empty, 7500));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);

                _temp = new Merchant($"Refinery Office");
                _temp.AddExportItem(new Listing(GameItem.Barrel_Diesel, 65000));
                _temp.AddExportItem(new Listing(GameItem.Barrel_Petrol, 68800));
                _temp.AddContract(new Contract(8, GameItem.Barrel_Diesel, Kolovy.myName, 12000));
                _temp.AddContract(new Contract(15, GameItem.Barrel_Diesel, Sterlikin.myName, 22500));
                _temp.AddContract(new Contract(10, GameItem.Barrel_Diesel, Lupova.myName, 17000));
                _temp.AddContract(new Contract(22, GameItem.Barrel_Diesel, Saversk.myName, 24200));
                _temp.AddContract(new Contract(28, GameItem.Barrel_Diesel, Komsodrinsk.myName, 50400));
                _temp.AddContract(new Contract(15, GameItem.Barrel_Petrol, Kolovy.myName, 28500));
                _temp.AddContract(new Contract(5, GameItem.Barrel_Petrol, Sterlikin.myName, 10000));
                _temp.AddContract(new Contract(3, GameItem.Barrel_Petrol, Saversk.myName, 5100));
                _temp.AddContract(new Contract(6, GameItem.Barrel_Petrol, Lupova.myName, 13800));
                _temp.AddContract(new Contract(14, GameItem.Barrel_Petrol, Komsodrinsk.myName, 32200));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);

            }

            return _myLoc;
        }
    }
}