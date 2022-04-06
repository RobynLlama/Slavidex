using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Saversk
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Saversk";
        private static Location fetch()
        {
            if (_myLoc == null)
            {
                _myLoc = new Location(myName, "A boring town with truly nothing going for it but proximity to other, more interesting, places");

                Merchant _temp = new Merchant("Caslav Groceries");
                _temp.AddExportItem(new Listing(GameItem.Coolant, 8500));
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5600));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 15900));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Slavli, 1200));
                _temp.AddExportItem(new Listing(GameItem.Smoked_Bread_Bacon, 1800));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Lecso, 550));
                _temp.AddExportItem(new Listing(GameItem.Mystery_Meat, 850));
                _temp.AddExportItem(new Listing(GameItem.Fish_Bream, 1200));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Smoked, 1400));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Paprika, 2100));
                _temp.AddExportItem(new Listing(GameItem.Beer, 250));
                _temp.AddExportItem(new Listing(GameItem.Beer_Case, 2520));
                _temp.AddExportItem(new Listing(GameItem.Pork_Can, 870));
                _temp.AddExportItem(new Listing(GameItem.Bread, 350));
                _temp.AddExportItem(new Listing(GameItem.Potato, 45));
                _temp.AddExportItem(new Listing(GameItem.Onion, 65));
                _temp.AddExportItem(new Listing(GameItem.Pepper, 75));
                _temp.AddExportItem(new Listing(GameItem.Tomato, 110));
                _temp.AddExportItem(new Listing(GameItem.Apple, 88));
                _temp.AddExportItem(new Listing(GameItem.Flour, 190));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pot, 30000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Plate, 550));
                _temp.AddExportItem(new Listing(GameItem.Zhukov_Vodka, 4500));
                _temp.AddExportItem(new Listing(GameItem.Peach_Palinka, 7000));
                _temp.AddExportItem(new Listing(GameItem.Water_Pack, 750));
                _temp.AddExportItem(new Listing(GameItem.Compass, 7900));
                _temp.AddExportItem(new Listing(GameItem.Rambro_Pack, 890));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("The Skinny Jackals");
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

                _temp = new Merchant($"{myName} Gas Station");
                _temp.AddExportItem(new Listing(GameItem.Barrel_Petrol_Empty,12000));
                _temp.AddExportItem(new Listing(GameItem.Barrel_Diesel_Empty,12000));
                _temp.AddImportItem(new Listing(GameItem.Barrel_Diesel, 61000));
                _temp.AddImportItem(new Listing(GameItem.Barrel_Petrol, 65000));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant($"{myName} Deliveries");
                _temp.AddContract(new Contract(11, GameItem.Delivery_Parcel, Komsodrinsk.myName, 18700));
                _temp.AddContract(new Contract(23, GameItem.Delivery_Parcel, Magyarfalu.myName, 27830));
                _temp.AddContract(new Contract(35, GameItem.Delivery_Parcel, Lupova.myName, 44450));
                
                _myLoc.AddVendor(_temp);
            }

            return _myLoc;
        }
    }
}