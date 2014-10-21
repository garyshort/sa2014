using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reducer
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            while ((line = Console.ReadLine()) != null)
            {
                string[] fields = line.Split('\t');
                string key = fields[0];
                string value = fields[1];
                string[] stats = value.Split(',');
                double index = stats.Sum(x => Convert.ToDouble(x));
                Console.WriteLine("{0}\t{1:.00}", key, index);
            }
        }
    }
}
