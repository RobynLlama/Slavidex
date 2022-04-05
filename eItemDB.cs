using Slavidex.LocationsDB;

namespace Slavidex.ItemsDB
{
    public static class GameItem
    {

        /********** FOOD ITEMS **********/
        public static Item Slavli = new Item("Slavli", "A jar of pickled fish, it melts in your mouth");
        public static Item Lecso = new Item("Lecso", "A tomato and pepper stew");
        public static Item Gulyas = new Item("Gulyas", "A flavorful meaty stew");
        public static Item Uhka = new Item("Uhka", "A type of fish stew");
        public static Item Kolbaz_Smoked = new Item("Smoked Kolbaz", "A smoked sausage");
        public static Item Kolbaz_Lecso = new Item("Lecso Kolbaz", "A smoked sausage");
        public static Item Kolbaz_Paprika = new Item("Paprika Kolbaz", "A smoked sausage");
        public static Item Pork_Can = new Item("Canned Pork", "Pork in a can. It'll probably last forever");
        public static Item Mystery_Meat = new Item("Mystery Meat", "Is it a bird, a cow, or roadkill? How thrilling!");
        public static Item Fish_Bream = new Item("Fish Bream", "A local fish, presumbably dried or salted");
        public static Item Smoked_Bread_Bacon = new Item("Smoked Bread Bacon", "Bread with a smokey flavor, probably?");
        public static Item Bread = new Item("Bread (1Kg)", "Wheat, water, heat, time. A staple food");

        /********** DRINK ITEMS **********/
        public static Item Peach_Palinka = new Item("Peach Palinka", "An alcoholic beverage");
        public static Item Zhukov_Vodka = new Item("Zhukov Vodka", "An alcoholic beverage");
        public static Item Beer = new Item("Burnerbraun Beer", "An alcoholic beverage");
        public static Item Beer_Case = new Item("Burnerbraun (12ct)", "A case of 12 alcoholic beverages");
        public static Item Water = new Item("Water Bottle", "Its what your body craves");
        public static Item Water_Pack = new Item("Water (6ct)", "Its what your body craves, six bottles.");

        /********** COOKING **********/
        public static Item Potato = new Item("Potato", "A staple food, used in cooking");
        public static Item Onion = new Item("Onion", "A staple food, used in cooking");
        public static Item Pepper = new Item("Pepper", "A staple food, used in cooking");
        public static Item Apple = new Item("Apple", "A staple food, used in cooking");
        public static Item Tomato = new Item("Tomato", "A staple food, used in cooking");
        public static Item Flour = new Item("Flour", "Baking flour, used to make bread");

        /********** SUNDRIES **********/
        public static Item Rambro_Pack = new Item("Rambro Cigarettes", "Surgeon Generals Warning: Cigarettes are bad, okay?");
        public static Item Compass = new Item("Compass", "Always faces north, unless you hold it sideways");
        public static Item Map = new Item($"Map of {Slaveria.myName}", "A map of the region to help keep you from getting lost");
        public static Item Binoculars = new Item("Binoculars", "Allows one to see about twice as far as normal");
        public static Item Cooking_Pot = new Item("Cast-Iron Pot", "A heavy pot for cooking soups and stocks");
        public static Item Cooking_Pan = new Item("Cast-Iron Pan", "A heavy pan good for retaining heat while cooking or searing");
        public static Item Cooking_Plate = new Item("Plate", "You eat food off of this. Its what seperates us from animals");
        public static Item LPG_Canister = new Item("LPG Canister", "A canister of Liquid Propane Gas. It fits right into your oven for cooking.");
        public static Item Toolbox = new Item("Toolbox", "Used to swap car parts");
        public static Item Car_Part_Adjuster = new Item("Vehicle Part Adjuster", "Used to adjust car parts");
        public static Item Repair_Kit_Medium = new Item("Repair Kit", "Repairs damaged car parts");
        public static Item Towbar = new Item("Towbar", "Used to link vehicles together for towing");
        public static Item Torch = new Item("Torch", "Lights up the night");
        public static Item Coolant = new Item("Coolant (4L)", "For refilling your radiator");
        public static Item Motor_Oil = new Item("Slavoline Motor Oil (2L)", "For quenching your engine's thirst");
        public static Item Gas_Can = new Item("Gas Jerrycan (20L)", "Holds extra Gasoline for emergencies");
        public static Item Diesel_Can = new Item("Diesel Jerrycan (20L)", "Holds extra Diesel for emergencies");
        public static Item Spray_Paint_Blue = new Item("Spray Can (Blue)", "Can be used to paint your vehicle");
        public static Item Spray_Paint_Red = new Item("Spray Can (Red)", "Can be used to paint your vehicle");
        public static Item Spray_Paint_Green = new Item("Spray Can (Green)", "Can be used to paint your vehicle");

        /********** TRADE GOODS **********/

        public static Item Pallet_Planks = new Item ("Pallet of Planks", "A pallet of straight-cut planks");
        public static Item Pallet_Empty = new Item ("Empty Pallets", "Empty pallets stacked up high");
        public static Item Pallet_Log = new Item ("Pallet of Logs", "A pallet of heavy logs");
        public static Item Pallet_Bricks = new Item ("Pallet of Bricks", "A pallet of stone bricks");
        public static Item Pallet_Concrete = new Item ("Pallet of Concrete Slabs", "A pallet of concrete slabs");
        public static Item Pallet_Pipes = new Item ("Pallet of Pipes", "A pallet of metal pipes");
        public static Item Pallet_Scrapmetal = new Item ("Pallet of Scrap Metal", "A pallet of old scrap metal");
        public static Item Pallet_Cement = new Item ("Pallet of Cement Bags", "A pallet of cement bags");
        public static Item Pallet_Consumer_Goods = new Item ("Pallet of Consumer Goods", "A pallet of food and sundries");
        public static Item Pallet_Industrial_Goods = new Item ("Pallet of Industrial Goods", "A pallet of industrial materials");
        public static Item Metal_Sheet = new Item ("Metal Sheets", "Scrap sheet metal");
        public static Item Barrel_Empty = new Item ("Empty Barrels", "A barrel with nothing in it");
        public static Item Barrel_Petrol = new Item ("Barrel of Gasoline", "A barrel filled to the brim with Gasoline");
        public static Item Barrel_Diesel = new Item ("Barrel of Diesel", "A barrel filled to bursting with Diesel fuel");
        public static Item Sack_Stone = new Item ("Sack of stones", "Some rocks in a sack");
        public static Item Sack_Salt = new Item ("Sack of Salt", "Some salt in a sack");
        public static Item Barrel_Petrol_Empty = new Item ("Empty Gasoline Barrel", "An empty barrel marked for filling with Gasoline");
        public static Item Barrel_Diesel_Empty = new Item ("Empty Diesel Barrel", "An empty barrel marked for filling with Diesel fuel");

        /********** ILLEGAL GOODS **********/
        public static Item Drug_Bag_Weed = new Item ("Weed Baggie", "Grass, ganja, Mary Jane. Packed into a baggie for personal use");        
        public static Item Drug_Bag_Meth = new Item ("Meth Baggie", "The drug of choice for midwesterners. Packed into a baggie for personal use");
        public static Item Drug_Bag_Cocaine = new Item ("Cocaine Baggie", "A fun powder made from the Coca leaf. Packed into a baggie for personal use");
        public static Item Drug_Brick_Hash = new Item ("Hash Brick", "A highly concentrated cannaboid. Packed into a brick for distribution");
        public static Item Drug_Brick_Meth = new Item ("Meth Brick", "More meth than you want or need. Packed into a brick for distribution");
        public static Item Drug_Brick_Cocaine = new Item ("Cocaine Brick", "Can you ever have too much of this stuff? Packed into a brick for distribution");

        /********** VEHICLE PARTS **********/

        public static Item Car_Radio = new Item ("Radio", "A radio designed to be mounted in a vehicle");

        /********** RUS-310 **********/
        public static Item Rus_310_Engine = new Item ("Rus-310 150HP Gas Engine","Makes your car go");
        public static Item Rus_310_Radiator = new Item ("Rus-310 Radiator","Stops the engine from exploding");
        public static Item Rus_310_Wheel_Front = new Item ("Rus-310 Wheel (Front)","Can't drive without these");
        public static Item Rus_310_Wheel_Rear = new Item ("Rus-310 Wheel (Rear)","Can't drive without these");
        public static Item Rus_310_Suspension_Front = new Item ("Rus-310 Suspension (Front)","Smooths out the bumps");
        public static Item Rus_310_Suspension_Rear = new Item ("Rus-310 Suspension (Rear)","Smooths out the bumps");
        public static Item Rus_310_Seat_Single = new Item ("Rus-310 Driver's Seat","Your butt goes here");
        public static Item Rus_310_Seat_Passenger = new Item ("Rus-310 Passanger's Seat","Good for napping");

        /********** ZAKMAT **********/
        public static Item Frame_Zakmat = new Item ("Zakmat Frame", "A shell of a formerly great Zakmat Truck. Its just the frame, bring your own truck");
        public static Item Zakmat_Suspension_Front = new Item ("Zakmat Suspension (Front)","Smooths out the bumps");
        public static Item Zakmat_Suspension_Rear = new Item ("Zakmat Suspension (Rear)","Smooths out the bumps");
        public static Item Jerkin_Radiator = new Item ("Jerkin Radiator","Has a higher coolant capacity than the RUS-310");
        public static Item Jerkin_Diesel_5L = new Item ("Jerkin 120HP Diesel Engine", "A fine fuel conserving engine");

        /********** POLOSKA **********/
        public static Item Car_Poloska = new Item ("Poloska-621", "A small two door vehicle with a rear mounted engine");
        public static Item Poloska_Engine = new Item ("Poloska-621 23HP Engine","vroom!");
        public static Item Poloska_Suspension_Front = new Item ("Poloska Suspension (Front)", "Squeaky");
        public static Item Poloska_Suspension_Rear = new Item ("Poloska Suspension (Rear)", "Squeaky");

        /********** SPECIAL **********/
        public static Item Delivery_Parcel = new Item ("Packages", "Deliver this to a destination for money");
        public static Item Vehicle_Repairs = new Item ("Repair Vehicle", "Fully repairs the current vehicle (purchased from the register at Vehicle Shops)");
        public static Item Real_Estate = new Item ("Shack", "A bare shack to lay your head down in");
        public static Item Motel_Room = new Item ("Motel Room", $"A night at {Slaveria.myName}'s finest establishment");


    }
}