using System;
using System.Collections.Generic;

namespace Slavidex {

    public class Merchant : Describable
    {

        //A list of items the merchant will sell
        private List<Listing> mySoldItems;
        public List<Listing> getExports => mySoldItems;

        //A list of items the merchant will purchase
        private List<Listing> myPurchasedItems;
        public List<Listing> getImports => myPurchasedItems;

        //A list of contracts the merchant offers
        private List<Contract> myContracts;
        public List<Contract> getContracts => myContracts;
        public bool HasExports => mySoldItems.Count > 0;
        public bool HasImports => myPurchasedItems.Count > 0;
        public bool HasContracts => myContracts.Count > 0;

        public bool useInTripCalc
        {
            get;
            protected set;
        }

        public Merchant(string name, string info = "No Extra Info") : base(name, info)
        {
            mySoldItems = new List<Listing>();
            myPurchasedItems = new List<Listing>();
            myContracts = new List<Contract>();
            useInTripCalc = false;
        }

        public void setTripCalcFlag(bool flag = true)
        {
            useInTripCalc = flag;
        }

        public void AddExportItem(Listing itemName)
        {
            if (mySoldItems.Contains(itemName)){
                Console.WriteLine($"[Error] {myName}.AddExportItem({itemName}) attempting to insert duplicate key into database.");
                return;
            }

            mySoldItems.Add(itemName);
        }

        public void AddImportItem(Listing itemName)
        {
            if (myPurchasedItems.Contains(itemName)){
                Console.WriteLine($"[Error] {myName}.AddImportItem({itemName}) attempting to insert duplicate key into database.");
                return;
            }

            myPurchasedItems.Add(itemName);
        }
        public void AddContract(Contract contractName)
        {
            if (myContracts.Contains(contractName))
            {
                Console.WriteLine("Contract error here");
                return;
            }

            myContracts.Add(contractName);
        }

        ///<Summary>Lists a Merchant's items for sale to the console</Summary>
        public void ListExports()
        {
            if (mySoldItems.Count == 0)
            {
                Console.WriteLine($"[Error] {myName}.ListSaleItems() database is empty");
                return;
            }

            foreach (Listing item in mySoldItems)
            {
                Console.WriteLine($"    {item}");
            }
        }
        
        ///<Summary>Lists a Merchant's desired imports to the console</Summary>
        public void ListImports()
        {
            if (!HasImports)
            {
                //No error because not every merchant buys goods
                return;
            }

            foreach (Listing item in myPurchasedItems)
            {
                Console.WriteLine($"    {item}");
            }
        }

        ///<Summary>Lists a Merchant's job contracts to the console</Summary>
        public void ListContracts()
        {
            if (!HasContracts)
            {
                //No error because not every merchant buys goods
                return;
            }

            foreach (Contract contract in myContracts)
            {
                Console.WriteLine($"    {contract}");
            }
        }
    }
}