using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Oasis
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Oasis";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName, $"{myName} is the seedy underbelly of the drug trade in {Slaveria.myName}. Stay away from this place, brother.");

                Merchant _temp = new Merchant("Drug Lord's Den", "A den of sin and iniquity. Pleasures can be bought or sold here if you don't fear for your soul");
                _temp.AddImportItem(new Listing(GameItem.Drug_Bag_Weed, 11000));
                _temp.AddImportItem(new Listing(GameItem.Drug_Bag_Cocaine, 15000));
                _temp.AddImportItem(new Listing(GameItem.Drug_Bag_Meth, 19000));
                _temp.AddImportItem(new Listing(GameItem.Drug_Brick_Hash, 55000));
                _temp.AddImportItem(new Listing(GameItem.Drug_Brick_Cocaine, 75000));
                _temp.AddImportItem(new Listing(GameItem.Drug_Brick_Meth, 95000));

                _temp.AddExportItem(new Listing(GameItem.Drug_Bag_Weed, 15000));
                _temp.AddExportItem(new Listing(GameItem.Drug_Bag_Cocaine, 19000));
                _temp.AddExportItem(new Listing(GameItem.Drug_Bag_Meth, 22000));
                _temp.AddExportItem(new Listing(GameItem.Drug_Brick_Hash, 75000));
                _temp.AddExportItem(new Listing(GameItem.Drug_Brick_Cocaine, 95000));
                _temp.AddExportItem(new Listing(GameItem.Drug_Brick_Meth, 110000));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Real Estate");
                _temp.AddExportItem(new Listing(GameItem.Real_Estate, 80000));

                _myLoc.AddVendor(_temp);
            }

            return _myLoc;
        }
    }
}