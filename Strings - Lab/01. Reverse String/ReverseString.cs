﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(input);
        }
    }
}
