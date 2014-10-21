using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduceWithSDK
{
    public class Reducer : ReducerCombinerBase
    {
        public override void Reduce(
            string key, 
            IEnumerable<string> values, 
            ReducerCombinerContext context)
        {
            string value = values
                .First()
                .Split(',')
                .Sum(x => Convert.ToDouble(x))
                .ToString();

            context.EmitKeyValue(key, value);
        }
    }
}
