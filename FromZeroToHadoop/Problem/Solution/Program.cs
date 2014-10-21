using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Program
    {
        static void Main()
        {
            Reduce(Map("one, two, two, three, three, three, four, four, four, four"));
        }

        private static List<Tuple<string, int>> Map(string input)
        {
            var list = new List<Tuple<string, int>>();

            input
                .Split(',')
                .ToList()
                .ForEach(word => 
                    list.Add(Tuple.Create<string, int>(word, 1)));

            return list;
        }

        private static void Reduce(List<Tuple<string, int>> list)
        {
            list
                .GroupBy(tuple => tuple.Item1)
                .ToList()
                .ForEach(group =>
                    Console.WriteLine(
                    "{0} appears {1} time(s)", 
                    group.Key.Trim(), 
                    group.Count()));
        }
    }
}
