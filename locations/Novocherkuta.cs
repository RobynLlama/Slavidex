using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Novocherkuta
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Novocherkuta";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName);

                Merchant _temp = new Merchant($"{myName} Goods");
                _temp.AddExportItem(new Listing(GameItem.Pallet_Consumer_Goods, 130000));
                _temp.AddContract(new Contract(4, GameItem.Pallet_Consumer_Goods, Eastport.myName, 102000));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);

                _temp = new Merchant($"{myName} Builders Merchant");
                _temp.AddExportItem(new Listing(GameItem.Pallet_Pipes, 63000));
                _temp.AddExportItem(new Listing(GameItem.Barrel_Empty, 7000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Scrapmetal, 30000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Concrete, 51000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Bricks, 82000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Cement, 49000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Empty, 69000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Planks, 99000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Planks, 98000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Empty, 68000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Bricks, 81000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Concrete, 50000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Scrapmetal, 29000));
                _temp.AddImportItem(new Listing(GameItem.Barrel_Empty, 6900));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Cement, 48000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Pipes, 62000));
                _temp.setTripCalcFlag();

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Фctober Яevolution Жrocery");
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5900));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 15000));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.LPG_Canister, 14000));
                _temp.AddExportItem(new Listing(GameItem.Slavli, 1000));
                _temp.AddExportItem(new Listing(GameItem.Smoked_Bread_Bacon, 1800));
                _temp.AddExportItem(new Listing(GameItem.Mystery_Meat, 850));
                _temp.AddExportItem(new Listing(GameItem.Fish_Bream, 1200));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Smoked, 1700));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Paprika, 2500));
                _temp.AddExportItem(new Listing(GameItem.Beer, 170));
                _temp.AddExportItem(new Listing(GameItem.Coolant, 8500));
                _temp.AddExportItem(new Listing(GameItem.Pork_Can, 890));
                _temp.AddExportItem(new Listing(GameItem.Bread, 290));
                _temp.AddExportItem(new Listing(GameItem.Potato, 45));
                _temp.AddExportItem(new Listing(GameItem.Onion, 65));
                _temp.AddExportItem(new Listing(GameItem.Pepper, 75));
                _temp.AddExportItem(new Listing(GameItem.Tomato, 110));
                _temp.AddExportItem(new Listing(GameItem.Apple, 99));
                _temp.AddExportItem(new Listing(GameItem.Flour, 200));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Plate, 550));
                _temp.AddExportItem(new Listing(GameItem.Zhukov_Vodka, 2900));
                _temp.AddExportItem(new Listing(GameItem.Peach_Palinka, 7900));
                _temp.AddExportItem(new Listing(GameItem.Water_Pack, 720));
                _temp.AddExportItem(new Listing(GameItem.Binoculars, 5900));
                _temp.AddExportItem(new Listing(GameItem.Rambro_Pack, 720));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Great Khan Tavern");
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