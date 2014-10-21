using System;
using System.Collections.Generic;
using System.Linq;

namespace Mapper
{
    class Program
    {
        static void Main()
        {
            string line = string.Empty;
            while ((line = Console.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                string horse = fields[0];
                string jockey = fields[1];
                string course = fields[2];

                string stats = GetStatsForHorseJockeyCourse(
                    horse,
                    jockey,
                    course);

                Console.WriteLine("{0}\t{1}", horse, stats);
            }
        }

        private static string GetStatsForHorseJockeyCourse(
            string horse,
            string jockey,
            string course)
        {
            string stats = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                stats +=
                    new Random(DateTime.Now.Millisecond).NextDouble() + ",";
            }

            return stats.Substring(0, stats.Length - 1);
        }
    }
}
