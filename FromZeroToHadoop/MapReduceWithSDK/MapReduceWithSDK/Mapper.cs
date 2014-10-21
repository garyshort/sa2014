using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Hadoop.MapReduce;

namespace MapReduceWithSDK
{
    public class Mapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            string[] fields = inputLine.Split(',');
            string horse = fields[0];
            string jockey = fields[1];
            string course = fields[2];

            string stats = GetStatsForHorseJockeyCourse(
                horse,
                jockey,
                course);

            context.EmitKeyValue(horse, stats);
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
