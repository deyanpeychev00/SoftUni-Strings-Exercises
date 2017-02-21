using System;

namespace _04.Character_Multiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstString = input[0];
            var secondString = input[1];

            var result = GetCharacterMultiplication(firstString, secondString);
            Console.WriteLine(result);             
         }


        private static long GetCharacterMultiplication(string firstString, string secondString)
        {
            var minStringLength = Math.Min(firstString.Length, secondString.Length);
            var sum = 0;
            for (int i = 0; i < minStringLength; i++)
            {
                sum += firstString[i] * secondString[i];
            }
            if (firstString.Length - minStringLength > 0)
            {
                for (int i = minStringLength; i < firstString.Length; i++)
                {
                    sum += firstString[i];
                }
            }
            else
            {
                for (int i = minStringLength; i < secondString.Length; i++)
                {
                    sum += secondString[i];
                }
            }
            return sum;
        }
    }
}
