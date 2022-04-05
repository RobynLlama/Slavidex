using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Kolovy
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Kolovy";
        private static Location fetch()
        {

            if (_myLoc == null)
            {
                _myLoc = new Location(myName, $"{myName} is a small coastal town best known for its proximity to {Eastport.myName}.");

                Merchant _temp = new Merchant("Eastern Essence Pub");
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

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Eastern Parcel Services");
                _temp.AddContract(new Contract(17, GameItem.Delivery_Parcel, Magyarfalu.myName, 18700));
                _temp.AddContract(new Contract(19, GameItem.Delivery_Parcel, Novocherkuta.myName, 21850));
                _temp.AddContract(new Contract(22, GameItem.Delivery_Parcel, Sterlikin.myName, 24640));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Mishas Finest");
                _temp.AddExportItem(new Listing(GameItem.Coolant, 8500));
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5900));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 15800));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.LPG_Canister, 18000));
                _temp.AddExportItem(new Listing(GameItem.Slavli, 1400));
                _temp.AddExportItem(new Listing(GameItem.Mystery_Meat, 850));
                _temp.AddExportItem(new Listing(GameItem.Smoked_Bread_Bacon, 1800));
                _temp.AddExportItem(new Listing(GameItem.Fish_Bream, 1200));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Lecso, 590));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Smoked, 1300));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Paprika, 2200));
                _temp.AddExportItem(new Listing(GameItem.Beer, 195));
                _temp.AddExportItem(new Listing(GameItem.Beer_Case, 2320));
                _temp.AddExportItem(new Listing(GameItem.Pork_Can, 820));
                _temp.AddExportItem(new Listing(GameItem.Bread, 310));
                _temp.AddExportItem(new Listing(GameItem.Potato, 45));
                _temp.AddExportItem(new Listing(GameItem.Onion, 65));
                _temp.AddExportItem(new Listing(GameItem.Pepper, 75));
                _temp.AddExportItem(new Listing(GameItem.Tomato, 110));
                _temp.AddExportItem(new Listing(GameItem.Apple, 79));
                _temp.AddExportItem(new Listing(GameItem.Flour, 210));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pan, 10000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pot, 30000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Plate, 550));
                _temp.AddExportItem(new Listing(GameItem.Zhukov_Vodka, 4900));
                _temp.AddExportItem(new Listing(GameItem.Peach_Palinka, 7100));
                _temp.AddExportItem(new Listing(GameItem.Water_Pack, 700));
                _temp.AddExportItem(new Listing(GameItem.Compass, 7400));
                _temp.AddExportItem(new Listing(GameItem.Rambro_Pack, 790));

                _myLoc.AddVendor(_temp);

                _temp = new Merchant("Vehicle Repairs and Services");
                _temp.AddExportItem(new Listing(GameItem.Spray_Paint_Blue, 6000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Suspension_Front, 78000));
                _temp.AddExportItem(new Listing(GameItem.Zakmat_Suspension_Rear, 78000));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Jerkin_Radiator, 175000));
                _temp.AddExportItem(new Listing(GameItem.Poloska_Engine, 177000));
                _temp.AddExportItem(new Listing(GameItem.Repair_Kit_Medium, 22500));
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5500));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 15800));
                _temp.AddExportItem(new Listing(GameItem.Vehicle_Repairs, 55000));

                _myLoc.AddVendor(_temp);
            }

            return _myLoc;
        }
    }
}