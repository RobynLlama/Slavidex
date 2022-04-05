using System;
using Slavidex.LocationsDB;

namespace Slavidex
{
    public static class Helpers 
    {
        ///<summary>Formats an integer to be display in Slaverian dollars like in the game</summary>
        public static string SlavFormat(int input)
        {
            string output = string.Format("{0:n0}",input);
            return $"{output.Replace(",",".").PadRight(8)} SD";
        }
        public static string SlavCredits => "SlaviDex written in C# by MamaLlama\nSource code soon to be available @ Github\nSlaviDex is licsened under the Creative Commons Non Comercial Share Alike 4.0 license (https://creativecommons.org/licenses/by-nc-sa/4.0/)";

        ///<summary>Converts strings into location objects. Mainly for use with user input</summary>
        public static Location GetLocationFromString(string name)
        {
            switch (name.ToLower())
            {
                case "batarsk":
                    return Balarsk.getLocation;
                case "eastport":
                    return Eastport.getLocation;
                case "kolovy":
                    return Kolovy.getLocation;
                case "komsodrinsk":
                    return Komsodrinsk.getLocation;
                case "lupova":
                    return Lupova.getLocation;
                case "magyarfalu":
                    return Magyarfalu.getLocation;
                case "novocherkuta":
                    return Novocherkuta.getLocation;
                case "oasis":
                    return Oasis.getLocation;
                case "sterlikin":
                    return Sterlikin.getLocation;
                default:
                    Console.WriteLine($"[Error] GetLocationFromString: Unknown location {name}");
                    return Slaveria.getLocation;
            }
        }
    }
}