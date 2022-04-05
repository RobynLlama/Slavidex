using System;
using Slavidex.LocationsDB;
using Slavidex.ItemsDB;
using Slavidex.Operations;

namespace Slavidex
{
    public class Program
    {
        public const int itemSpacing = 44;
        static void Main(string[] args)
        {
            Console.WriteLine("Debugging Slavidex:");
            Functions.TripCalc(Balarsk.getLocation, Lupova.getLocation);
            Functions.TripCalc(Lupova.getLocation, Balarsk.getLocation);
        }
    }
}
