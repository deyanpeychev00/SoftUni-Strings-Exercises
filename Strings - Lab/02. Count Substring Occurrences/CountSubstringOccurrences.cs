using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring_Occurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var counter = 0;

            var index = input.IndexOf(pattern);
            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
