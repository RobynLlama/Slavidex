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
            Novocherkuta.getLocation.DisplayInfo(true, true, true);
            Functions.TripCalc(Novocherkuta.getLocation, Balarsk.getLocation, true);
            Functions.TripCalc(Novocherkuta.getLocation, Lupova.getLocation, true);
        }
    }
}
