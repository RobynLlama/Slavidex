using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Lupova
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Lupova";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName, $"{myName} is a medium sized town and heart of {Slaveria.myName}'s brick and concrete production.");

                Merchant _temp = new Merchant($"{myName} Building Materials Factory");
                _temp.AddExportItem(new Listing(GameItem.Pallet_Bricks, 78500));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Concrete, 49800));
                _temp.AddImportItem(new Listing(GameItem.Sack_Stone, 2950));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Cement, 59000));
                _temp.AddContract(new Contract(8, GameItem.Pallet_Bricks, Eastport.myName, 136000));
                _temp.AddContract(new Contract(4, GameItem.Pallet_Concrete, Eastport.myName, 92000));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Vehicle Repairs and Services");
                _temp.AddExportItem(new Listing(GameItem.Spray_Paint_Red, 6000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Suspension_Front, 68000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Suspension_Front, 22000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Suspension_Rear, 22000));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Repair_Kit_Medium, 17500));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 11800));
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5100));
                _temp.AddExportItem(new Listing(GameItem.Towbar, 35000));
                _temp.AddExportItem(new Listing(GameItem.Jerkin_Diesel_5L, 479000));
                _temp.AddExportItem(new Listing(GameItem.Car_Poloska, 1020000));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Motela Rusaka");
                _temp.AddExportItem(new Listing(GameItem.Motel_Room, 6400));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Nowa Warszawa");
                _temp.AddExportItem(new Listing(GameItem.Apple, 81));
                _temp.AddExportItem(new Listing(GameItem.Lecso, 1250));
                _temp.AddExportItem(new Listing(GameItem.Gulyas, 1520));
                _temp.AddExportItem(new Listing(GameItem.Uhka, 980));
                _temp.AddExportItem(new Listing(GameItem.Bread, 380));
                _temp.AddExportItem(new Listing(GameItem.Rambro_Pack, 820));
                _temp.AddExportItem(new Listing(GameItem.Beer,210));
                _temp.AddExportItem(new Listing(GameItem.Slavli,790));
                _temp.AddExportItem(new Listing(GameItem.Water,140));
                _temp.AddExportItem(new Listing(GameItem.Peach_Palinka,7500));
                _temp.AddExportItem(new Listing(GameItem.Zhukov_Vodka,5200));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Latawica Delivery");
                _temp.AddContract(new Contract(35, GameItem.Delivery_Parcel, Komsodrinsk.myName, 59500));
                _temp.AddContract(new Contract(13, GameItem.Delivery_Parcel, Komsodrinsk.myName, 21970));
                _temp.AddContract(new Contract(22, GameItem.Delivery_Parcel, Balarsk.myName, 26070));
                _temp.AddContract(new Contract(17, GameItem.Delivery_Parcel, Saversk.myName, 18360));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant($"{myName} Fueling Station");
                _temp.AddExportItem(new Listing(GameItem.Barrel_Petrol_Empty,12000));
                _temp.AddExportItem(new Listing(GameItem.Barrel_Diesel_Empty,12000));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Shady Drug Dealer");
                _temp.AddExportItem(new Listing(GameItem.Drug_Bag_Weed, 7800));
                _temp.AddImportItem(new Listing(GameItem.Drug_Brick_Hash, 90000));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Polak Building Materials Merchant");
                _temp.AddExportItem(new Listing(GameItem.Pallet_Pipes, 68000));
                _temp.AddExportItem(new Listing(GameItem.Barrel_Empty, 7400));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Scrapmetal, 20000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Cement, 59000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Empty, 67000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Industrial_Goods, 38000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Consumer_Goods, 140000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Planks, 96000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Planks, 95000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Empty, 66000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Scrapmetal, 18000));
                _temp.AddImportItem(new Listing(GameItem.Barrel_Empty, 7100));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Cement, 57000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Pipes, 67000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Industrial_Goods, 37000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Consumer_Goods, 135000));

                _myLoc.AddVendor(_temp);
                _myLoc.SetMaterialVendor(_temp);

                
            }

            return _myLoc;
        }
    }
}