using System;

namespace Slavidex
{
    public class Contract
    {
        public int numItems;
        public Item itemType;
        public string destination;
        public int payment;

        public Contract(int items, Item iType, string dest, int pay)
        {
            numItems = items;
            itemType = iType;
            destination = dest;
            payment = pay;
        }

        public override string ToString()
        {
            return $"{numItems} {itemType} to {destination} ".PadRight(Program.itemSpacing) + $"{Helpers.SlavFormat(payment)}";
        }
    }
}