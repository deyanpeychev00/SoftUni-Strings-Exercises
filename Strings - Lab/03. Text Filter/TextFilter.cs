using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (input.Contains(word))
                {
                    input = input.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(input);
        }
    }
}
