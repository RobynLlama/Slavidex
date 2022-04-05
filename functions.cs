/*
This is where the functions that actually perform calculations on the database live
*/

using System;
using System.Collections.Generic;

namespace Slavidex.Operations
{
    public static class Functions
    {
        ///<summary>Outputs the value of all cargo when shipped from StartLoc to EndLoc</summary>
        public static void TripCalc(Location StartLoc, Location EndLoc, bool RoundTrip = false)
        {
            Console.WriteLine($"When buying from {StartLoc.myName} and selling at {EndLoc.myName}");
            Console.WriteLine("The following items turn a profit:");

            //Collect all valid vendors from the start and end location
            List<Merchant> startVendors = new List<Merchant>();
            List<Merchant> endVendors = new List<Merchant>();

            foreach (Merchant vendor in StartLoc.getVendors)
            {
                if (vendor.useInTripCalc)
                    startVendors.Add(vendor);
            }

            foreach (Merchant vendor in EndLoc.getVendors)
            {
                if (vendor.useInTripCalc)
                    endVendors.Add(vendor);
            }

            //Now try to run a route from each vendor
            foreach (Merchant curVendor in startVendors)
            {
                foreach (Merchant sellVendor in endVendors)
                {
                    TripCalc(curVendor, sellVendor);
                }
            }

            //Do the roundtrip for us lazy devs
            if (RoundTrip)
            {
                TripCalc(EndLoc, StartLoc);
            }
        }

        private static void TripCalc(Merchant StartVendor, Merchant EndVendor)
        {
            //Keep track of the state of our header
            bool headerDone = false;

            //Try to sell each item from the start to end vendor
            foreach (Listing sList in StartVendor.getExports)
            {
                foreach (Listing eList in EndVendor.getImports)
                {
                    //If the bought and sold item match
                    if (sList.GetItem == eList.GetItem)
                    {
                        //if the price of the bought item is less
                        if (sList.myPrice < eList.myPrice)
                        {
                            //We got a weiner
                            //Print what store we are in because we have at least one item that we can sell
                            if (!headerDone)
                            {
                                Console.WriteLine($"  From {StartVendor.myName} to {EndVendor.myName}");
                                headerDone = true;
                            }

                            Console.WriteLine($"    {sList.GetItem.myName} : ".PadRight(Program.tripCalcItemSpacing) + $"{Helpers.SlavFormat(eList.myPrice - sList.myPrice)}");
                        }
                    }
                }
            }

            if (headerDone)
            {
                //Add some spacing if we outputted anything
                Console.WriteLine("");
            }
        }
    }
}