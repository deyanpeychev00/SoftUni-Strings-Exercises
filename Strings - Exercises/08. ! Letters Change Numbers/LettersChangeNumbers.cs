using System;
using System.Collections.Generic;

namespace _08.__Letters_Change_Numbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var separatedInput = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                separatedInput.Add(input[i]);
            }
            var sum = 0.0;
            foreach (var line in separatedInput)
            {
                sum += GetLettersAsNumbers(line);
            }
            Console.WriteLine($"{sum:f2}");
        }

        private static double GetLettersAsNumbers(string line)
        {

            var firstLetter = line[0];
            var lastLetter = line[line.Length - 1];

            line = line.Trim(lastLetter);
            line = line.Trim(firstLetter);

            var number = double.Parse(line);
            var firstLetterPos = GetLetterPositon(firstLetter);
            var lastLetterPos = GetLetterPositon(lastLetter);
            var sum = 0.0;

            if (char.IsUpper(firstLetter))
            {
                sum = number / firstLetterPos;
            }
            else
            {
                sum = number * firstLetterPos;
            }

            if (char.IsUpper(lastLetter))
            {
                sum = sum - lastLetterPos;
            }
            else
            {
                sum = sum + lastLetterPos;
            }

            return sum;
        }

        private static int GetLetterPositon(char letter)
        {
            var position = 0;
            if (char.IsUpper(letter))
            {
                position = letter - 'A';
            }
            else
            {
                position = letter - 'a';
            }
            return position+1;
        }
    }
}
