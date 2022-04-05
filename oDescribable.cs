namespace Slavidex
{
    public abstract class Describable
    {
        public string myName 
        {
            get;
            protected set;
        }
        public string myExtraInfo 
        {
            get;
            protected set;
        }
        public Describable(string name, string info = "No Extra Info")
        {
            myName = name;
            myExtraInfo = info;
        }

        public override string ToString()
        {
            return myName;
        }
    }
}