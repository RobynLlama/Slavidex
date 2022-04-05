using System;
using System.Collections.Generic;

namespace Slavidex {

    public class Location : Describable
    {

        private List<Merchant> myVendors;
        public List<Merchant> getVendors => myVendors;

        //This is used in trip calculations and should exist within the
        //Location's vendor list myVendors
        private Merchant myMaterialVendor = null;
        public Merchant GetMaterialVendor => myMaterialVendor;

        public Location(string name, string info = "No Extra Info") : base(name, info)
        {
            myVendors = new List<Merchant>();
        }

        public void AddVendor(Merchant vendor)
        {
            if (myVendors.Contains(vendor))
            {
                Console.WriteLine($"[Error] {myName}.AddVendor({vendor.myName}) attempting to insert duplicate key into database.");
                return;
            }

            myVendors.Add(vendor);
        }

        public void SetMaterialVendor(Merchant vendor)
        {

            if (!myVendors.Contains(vendor))
            {
                Console.WriteLine($"[Error] {myName}.SetMaterialVendor({vendor.myName} vendor does not exist in location's vendor database.)");
                return;
            }

            myMaterialVendor = vendor;
        }

        public void DisplayInfo(bool vDetailed = false, bool eDetailed = false, bool cDetailed = false)
        {
            Console.WriteLine($"Extended Details for {myName}");
            Console.WriteLine($"The following places may be of interest: ");
            foreach (Merchant merch in myVendors)
            {
                Console.WriteLine("");
                Console.WriteLine($"  [ {merch.myName} ]");

                if (vDetailed)
                    if (merch.HasExports)
                    {
                    Console.WriteLine("  Sells:");
                    merch.ListExports();
                    }
                if (eDetailed)
                    if (merch.HasImports)
                    {
                        Console.WriteLine("  Buys:");
                        merch.ListImports();
                    }
                if (cDetailed)
                    if (merch.HasContracts)
                    {
                        Console.WriteLine("  Jobs:");
                        merch.ListContracts();
                    }
                    
            }

            if (eDetailed) 
            {
                Console.WriteLine("");
                Console.WriteLine($"{myExtraInfo}");
            }
            Console.WriteLine("");
        }
    }
}