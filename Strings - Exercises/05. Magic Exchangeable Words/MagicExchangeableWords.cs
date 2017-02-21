using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05.Magic_Exchangeable_Words
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstString = input[0];
            var secondString = input[1];

            var result = AreWordsExchangable(firstString, secondString);
            if (result)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            
        }

        private static bool AreWordsExchangable(string firstString, string secondString)
        {
            var areEqual = true;
            var map = new Dictionary<char, int>();
            if (firstString.Length == secondString.Length)
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    char firstChar = firstString[i];
                    char secondChar = secondString[i];
                    if (!map.ContainsKey(firstChar))
                    {
                        map.Add(firstChar, secondChar);
                    }
                    else
                    {
                        if (!map.ContainsValue(secondChar))
                        {
                            areEqual = false;
                        }
                    }
                }
            }
            else
            {
                areEqual = false;
            }

            return areEqual;
        }
    }
}
