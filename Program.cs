using System;
using Slavidex.LocationsDB;
using Slavidex.ItemsDB;
using Slavidex.Operations;

namespace Slavidex
{
    public class Program
    {
        public const int detailedListItemSpacing = 44;
        public const int tripCalcItemSpacing = 60;
        static void Main(string[] args)
        {
            Console.WriteLine("Debugging Slavidex:");
            Magyarfalu.getLocation.DisplayInfo(true, true, true);
        }
    }
}
