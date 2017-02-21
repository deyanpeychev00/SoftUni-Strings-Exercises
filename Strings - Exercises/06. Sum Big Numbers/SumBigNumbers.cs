using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Sum_Big_Numbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = BigInteger.Parse(Console.ReadLine());
            var secondNum = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(firstNum + secondNum);

        }
    }
}
