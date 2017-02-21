﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseN = int.Parse(input[0]);
            var baseTen = BigInteger.Parse(input[1]);
            var result = ConvertFrom10ToN(baseTen, baseN);
            Console.WriteLine(result);
        }

        static string ConvertFrom10ToN(BigInteger baseTen, int baseN)
        {
            var result = string.Empty;

            while (baseTen > 0)
            {
                var remainder = baseTen % baseN;
                result = remainder + result;
                baseTen /= baseN;
            }
            return result;
        }
    }
}
