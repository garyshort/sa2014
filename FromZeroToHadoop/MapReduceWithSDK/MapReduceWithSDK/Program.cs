﻿using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduceWithSDK
{
    class Program
    {
        static void Main(string[] args)
        {
            HadoopJobConfiguration conf = new HadoopJobConfiguration()
            {
                InputPath = "/demo/in",
                OutputFolder = "/demo/out"
            };

            Hadoop.Connect(new Uri("http://win8-dev-pc/"), "hadoop", "")
                .MapReduceJob
                .Execute<Mapper, Reducer>(conf);

        }
    }
}
