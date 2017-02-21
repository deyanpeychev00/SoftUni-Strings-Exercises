using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var delimiters = new char[] { ' ', ',', '.', '?', '!' };
            var input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new HashSet<string>();
            foreach (var word in input)
            {
                var wordRev = new string(word.Reverse().ToArray());
                if (wordRev == word)
                {
                    palindromes.Add(word);
                }
            }
            var result = palindromes.OrderBy(name => name);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
