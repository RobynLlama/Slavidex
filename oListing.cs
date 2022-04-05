namespace Slavidex
{
    public class Listing
    {

        protected Item myItem;
        public Item GetItem => myItem;
        public int myPrice
        {
            get;
            protected set;
        }

        protected bool specialText = false;

        public Listing(Item listing, int price, bool special = false)
        {
            myItem = listing;
            myPrice = price;
            specialText = special;
        }

        public override string ToString()
        {
            return myItem.ToString().PadRight(Program.itemSpacing) + Helpers.SlavFormat(myPrice);
        }
    }
}