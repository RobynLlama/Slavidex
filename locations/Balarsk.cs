/*
Todo:
    Gurinsk
    Jacek's
    Stepanovich Coal Mine
    Kolovy
    Eastport
    Tarasov Oil Field
    Oasis
    Lupova
    Magyarfalu
    Saversk
    Lake Bogdan
    Poniatowsk Food Factory
    Novocherkuta
    Sterlikin
    Gonsk
    Romanovich Oil Refinery
    Dolgotov Saltflat
    Iron Mine
    Garbage Dump
*/

using Slavidex.ItemsDB;

namespace Slavidex.LocationsDB
{
    public static class Balarsk
    {

        private static Location _myLoc;
        public static Location getLocation => fetch();
        public static string myName = "Balarsk";
        private static Location fetch()
        {
            
            if (_myLoc == null)
            {
                //Init location
                _myLoc = new Location(myName, $"{myName} is the nearest location to the starting home at {Gurinsk.myName} and often first stop for new players. {myName} is the only town lacking a petrol station.");

                //Sawmill
                Merchant _temp = new Merchant($"{myName} Sawmill");
                _temp.setTripCalcFlag();
                _temp.AddExportItem(new Listing(GameItem.Pallet_Planks, 81500));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Empty, 59700));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Log, 81500));
                _temp.AddContract(new Contract(2, GameItem.Pallet_Planks, Komsodrinsk.myName, 78000));
                _temp.AddContract(new Contract(4, GameItem.Pallet_Planks, Komsodrinsk.myName, 156000));
                _temp.AddContract(new Contract(4, GameItem.Pallet_Empty, Komsodrinsk.myName, 71600));
                _temp.AddContract(new Contract(4, GameItem.Pallet_Planks, Eastport.myName, 68000));
                _temp.AddContract(new Contract(4, GameItem.Pallet_Empty, Eastport.myName, 26400));

                _myLoc.AddVendor(_temp);

                //Sadizlav and Sons Groceries
                _temp = new Merchant("Sadizlav and Sons Groceries");
                _temp.AddExportItem(new Listing(GameItem.Coolant, 8500));
                _temp.AddExportItem(new Listing(GameItem.Motor_Oil, 5500));
                _temp.AddExportItem(new Listing(GameItem.Torch, 15000));
                _temp.AddExportItem(new Listing(GameItem.Toolbox, 15800));
                _temp.AddExportItem(new Listing(GameItem.Gas_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.Diesel_Can, 4000));
                _temp.AddExportItem(new Listing(GameItem.LPG_Canister, 15000));
                _temp.AddExportItem(new Listing(GameItem.Mystery_Meat, 850));
                _temp.AddExportItem(new Listing(GameItem.Smoked_Bread_Bacon, 1800));
                _temp.AddExportItem(new Listing(GameItem.Fish_Bream, 1200));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Lecso, 550));
                _temp.AddExportItem(new Listing(GameItem.Kolbaz_Paprika, 2200));
                _temp.AddExportItem(new Listing(GameItem.Beer, 195));
                _temp.AddExportItem(new Listing(GameItem.Pork_Can, 820));
                _temp.AddExportItem(new Listing(GameItem.Bread, 310));
                _temp.AddExportItem(new Listing(GameItem.Potato, 45));
                _temp.AddExportItem(new Listing(GameItem.Onion, 65));
                _temp.AddExportItem(new Listing(GameItem.Pepper, 75));
                _temp.AddExportItem(new Listing(GameItem.Tomato, 110));
                _temp.AddExportItem(new Listing(GameItem.Apple, 79));
                _temp.AddExportItem(new Listing(GameItem.Flour, 190));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pan, 12000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Pot, 30000));
                _temp.AddExportItem(new Listing(GameItem.Cooking_Plate, 550));
                _temp.AddExportItem(new Listing(GameItem.Zhukov_Vodka, 4900));
                _temp.AddExportItem(new Listing(GameItem.Water_Pack, 700));
                _temp.AddExportItem(new Listing(GameItem.Map, 15000));
                _temp.AddExportItem(new Listing(GameItem.Rambro_Pack, 790));

                _myLoc.AddVendor(_temp);

                //Kovalenko's Builders Merchant
                _temp = new Merchant("Kovalenko's Builders Merchant");
                _temp.setTripCalcFlag();
                _temp.AddExportItem(new Listing(GameItem.Pallet_Pipes, 65000));
                _temp.AddExportItem(new Listing(GameItem.Barrel_Empty, 6100));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Scrapmetal, 25000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Concrete, 55000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Bricks, 82000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Cement, 39000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Industrial_Goods, 37000));
                _temp.AddExportItem(new Listing(GameItem.Pallet_Consumer_Goods, 141000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Bricks, 81000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Concrete, 54000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Scrapmetal, 24000));
                _temp.AddImportItem(new Listing(GameItem.Barrel_Empty, 6000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Cement, 38000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Pipes, 64000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Industrial_Goods, 36000));
                _temp.AddImportItem(new Listing(GameItem.Pallet_Consumer_Goods, 140000));
                _temp.AddImportItem(new Listing(GameItem.Metal_Sheet, 3500));

                _myLoc.AddVendor(_temp);
            }
            
            return _myLoc;
        }
    }
}