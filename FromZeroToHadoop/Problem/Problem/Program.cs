using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem
{
    class Program
    {
        static void Main()
        {
            "one, two, two, three, three, three, four, four, four, four"
                .Split(',')
                .GroupBy(x => x)
                .ToList()
                .ForEach(group => 
                    Console.WriteLine(
                        "{0} appears {1} time(s)", 
                        group.Key.Trim(), 
                        group.Count()));
        }
    }
}
