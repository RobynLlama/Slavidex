using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Magyarfalu
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Magyarfalu";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName);
                
                Merchant _temp = new Merchant($"{myName} Vehicle Shop");
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Hood, 59000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Engine, 105000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Hood, 88000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Hood, 41000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Radiator, 103000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Door, 73000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Bumper, 21000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Wheel_Front, 82000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Wheel_Rear, 164000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Wheel, 22000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Bumper, 15000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Engine_Cover, 49000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Rearshelf, 5500));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Bumper, 9800));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Door, 67000));
                _temp.AddExportItem(new Listing(GameItem.Ludu_Wheel, 52000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Seat_Single, 11000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Seat_Passenger, 19000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Seat_Single, 12000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Seat_Passenger, 21000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Covered_Wooden_Bed, 512000));
                _temp.AddImportItem(new Listing(GameItem.Car_Parts, 0, special:true));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Magyar Ízek");
                _temp.AddExportItem(new Listing(GameItem.Coolant, 8900));
                _temp.AddExportItem(new Listing(GameItem.Spray_Paint_Yellow, 6000));
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5300));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 15800));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.LPG_Canister, 16000));
                _temp.AddExportItem(new Listing(GameItem.Slavli, 1350));
                _temp.AddExportItem(new Listing(GameItem.Smoked_Bread_Bacon, 1800));
                _temp.AddExportItem(new Listing(GameItem.Mystery_Meat, 850));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Lecso, 500));
                _temp.AddExportItem(new Listing(GameItem.Fish_Bream, 1200));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Smoked, 1000));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Paprika, 1900));
                _temp.AddExportItem(new Listing(GameItem.Beer, 205));
                _temp.AddExportItem(new Listing(GameItem.Pork_Can, 860));
                _temp.AddExportItem(new Listing(GameItem.Bread, 310));
                _temp.AddExportItem(new Listing(GameItem.Potato, 45));
                _temp.AddExportItem(new Listing(GameItem.Onion, 65));
                _temp.AddExportItem(new Listing(GameItem.Pepper, 75));
                _temp.AddExportItem(new Listing(GameItem.Tomato, 110));
                _temp.AddExportItem(new Listing(GameItem.Apple, 79));
                _temp.AddExportItem(new Listing(GameItem.Flour, 180));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pan, 13000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pot, 30000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Plate, 550));
                _temp.AddExportItem(new Listing(GameItem.Peach_Palinka, 6200));
                _temp.AddExportItem(new Listing(GameItem.Water_Pack, 720));
                _temp.AddExportItem(new Listing(GameItem.Rambro_Pack, 800));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Vaskampó");
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

                _temp = new Merchant("HH Delivery");
                _temp.AddContract(new Contract(17, GameItem.Delivery_Parcel, Sterlikin.myName, 18870));
                _temp.AddContract(new Contract(12, GameItem.Delivery_Parcel, Saversk.myName, 19840));
                _temp.AddContract(new Contract(21, GameItem.Delivery_Parcel, Kolovy.myName, 20790));

                _myLoc.AddVendor(_temp);

            }

            return _myLoc;
        }
    }
}