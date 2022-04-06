using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Sterlikin
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Sterlikin";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName, $"{myName} lies on a crossroads between an Oil Refinery and a Stone Quarry making it the start or end point of many lucrative hauling routes.");

                Merchant _temp = new Merchant($"{myName} Vehicle Shop");
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Diesel_10L, 788000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Engine, 568000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Hood, 88000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Door, 67000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Door, 73000));
                _temp.AddExportItem(new Listing(GameItem.Fahrzeug_Wheel, 61000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Hood, 41000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Engine_Cover, 49000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Seat_Single, 11000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Seat_Passenger, 19000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Door, 76000));
                _temp.AddExportItem(new Listing(GameItem.Rus_310_Wooden_Bed, 255000));
                _temp.AddImportItem(new Listing(GameItem.Car_Parts, 0, special:true));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Big Vadim's Building Materials");
                _temp.AddExportItem(new Listing(GameItem.Pallet_Pipes, 60000));
                _temp.AddExportItem(new Listing(GameItem.Barrel_Empty, 5000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Scrapmetal, 35000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Concrete, 49000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Bricks, 85000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Cement, 49000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Industrial_Goods, 40000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Consumer_Goods, 150000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Planks, 98000));

                _temp.AddImportItem(new Listing(GameItem.Pallet_Planks, 97000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Empty, 71000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Bricks, 84000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Concrete, 48000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Scrapmetal, 34000));
                _temp.AddImportItem(new Listing(GameItem.Barrel_Empty, 4900));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Cement, 48000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Pipes, 59000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Industrial_Goods, 39000));
                _temp.AddImportItem(new Listing(GameItem.Metal_Sheet, 2900));
                _temp.AddImportItem(new Listing(GameItem.Plywood, 3200));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Consumer_Goods, 149000));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Antonina & Jerislav Grocery");
                _temp.AddExportItem(new Listing(GameItem.Coolant, 8500));
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5200));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 17000));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.LPG_Canister, 15000));
                _temp.AddExportItem(new Listing(GameItem.Slavli, 1100));
                _temp.AddExportItem(new Listing(GameItem.Smoked_Bread_Bacon, 1800));
                _temp.AddExportItem(new Listing(GameItem.Mystery_Meat, 850));
                _temp.AddExportItem(new Listing(GameItem.Fish_Bream, 1200));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Lecso, 550));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Paprika, 2500));
                _temp.AddExportItem(new Listing(GameItem.Beer, 190));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pan, 11000));
                _temp.AddExportItem(new Listing(GameItem.Flour, 190));
                _temp.AddExportItem(new Listing(GameItem.Pork_Can, 860));
                _temp.AddExportItem(new Listing(GameItem.Bread, 350));
                _temp.AddExportItem(new Listing(GameItem.Potato, 45));
                _temp.AddExportItem(new Listing(GameItem.Onion, 65));
                _temp.AddExportItem(new Listing(GameItem.Pepper, 75));
                _temp.AddExportItem(new Listing(GameItem.Tomato, 110));
                _temp.AddExportItem(new Listing(GameItem.Apple, 88));
                _temp.AddExportItem(new Listing(GameItem.Torch, 11000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Plate, 550));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pot, 30000));
                _temp.AddExportItem(new Listing(GameItem.Zhukov_Vodka, 4800));
                _temp.AddExportItem(new Listing(GameItem.Peach_Palinka, 7000));
                _temp.AddExportItem(new Listing(GameItem.Water_Pack, 780));            
                _temp.AddExportItem(new Listing(GameItem.Rambro_Pack, 720));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Steppe Deliveries");
                _temp.AddContract(new Contract(30, GameItem.Delivery_Parcel, Kolovy.myName, 29700));
                _temp.AddContract(new Contract(25, GameItem.Delivery_Parcel, Novocherkuta.myName, 34750));
                _temp.AddContract(new Contract(19, GameItem.Delivery_Parcel, Magyarfalu.myName, 20900));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("The Real Bolsheviks Tavern");
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
            }

            return _myLoc;
        }
    }
}