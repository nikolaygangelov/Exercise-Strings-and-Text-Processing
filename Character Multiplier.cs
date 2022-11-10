using System;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string currentWord = words[0];
            string nextWord = words[1];

            double sum = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                sum = MultiplyAscii(currentWord, nextWord);
            }
            Console.WriteLine(sum);
        }

        public static double MultiplyAscii(string currentWord, string nextWord)
        {
            double sum = 0;
            if (currentWord.Length <= nextWord.Length)
            {
                for (int j = 0; j < currentWord.Length; j++)
                {
                    sum += (int)currentWord[j] * (int)nextWord[j];
                }

                for (int k = currentWord.Length; k < nextWord.Length; k++)
                {
                    sum += (int)nextWord[k];
                }
            }
            else
            {
                for (int j = 0; j < nextWord.Length; j++)
                {
                    sum += (int)currentWord[j] * (int)nextWord[j];
                }

                for (int k = nextWord.Length; k < currentWord.Length; k++)
                {
                    sum += (int)currentWord[k];
                }
            }
            return sum;
        }
    }
}
