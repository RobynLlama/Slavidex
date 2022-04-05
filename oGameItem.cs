namespace Slavidex
{
    public class Item : Describable
    {
        public Item(string itemName, string itemDesc) : base(itemName, itemDesc)
        {

        }

        public override bool Equals(object input)
        {
            if (input == null)
             return false;

            if (input is string)
            {
                return (myName == (string)input);
            }

            if (input is Item)
            {
                return (myName == ((Item)input).myName);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return myName.GetHashCode();
        }
    }
}