﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdasExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> mostExpensive =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select comic;

            foreach (Comic comic in mostExpensive)
                Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
        }
    }
}
