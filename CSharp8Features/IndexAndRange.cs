using System;
using static System.Console;

namespace CSharp8Features
{
    internal class IndexAndRange
    {
        static void Main(string[] args)
        {
            //Struct Index - System.Index
            string[] cities =
                {                           //Index from start      //index from end  
                "Chennai",              // 0                                //^6 
                "Bengaluru",            // 1                                // ^5
                "Pune",                     // 2                                // ^4
                "Mumbai",
                "Delhi",
                "Hyderabad"         // 5                                    // ^1
                };
            WriteLine($"Usual Index :{cities[0]}");//Chennai
            WriteLine($"Indices from end :{cities[^6]}");//Chennai
            WriteLine();
            //Range is a struct - System.Range
            var cityNames = cities[2..5]; // stores "Pune", "Mumbai" and "Delhi" excludes index number 5 ("Hyderabad")
            foreach (var name in cityNames)
            {
                WriteLine(name);
            }
        }
    }
}
