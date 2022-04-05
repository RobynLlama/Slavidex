/*
This is where the functions that actually perform calculations on the database live
*/

using System;

namespace Slavidex.Operations
{
    public static class Functions
    {
        ///<summary>Outputs the value of all cargo when shipped from StartLoc to EndLoc</summary>
        public static void TripCalc(Location StartLoc, Location EndLoc)
        {
            Console.WriteLine($"When buying from {StartLoc.myName} and selling at {EndLoc.myName}");
            Console.WriteLine("The following items turn a profit:");

            //Get each sold item in the start location
            foreach (Listing list in StartLoc.GetMaterialVendor.getSoldItems)
            {
                //Check if it is sold at the End location
                foreach (Listing eList in EndLoc.GetMaterialVendor.getBuyItems)
                {
                    if (list.GetItem.myName == eList.GetItem.myName)
                    {
                        if (list.myPrice < eList.myPrice)
                        {
                            Console.WriteLine($"  {list.GetItem.myName} : ".PadRight(Program.itemSpacing) + $"{Helpers.SlavFormat(eList.myPrice - list.myPrice)}");
                        }
                    }
                }
            }
        }
    }
}