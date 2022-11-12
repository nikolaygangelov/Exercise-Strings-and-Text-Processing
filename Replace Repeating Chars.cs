using System;

namespace _6.__Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)//aab
            {
                char currentLetter = text[i];
                Console.Write(currentLetter);
                if (i == text.Length - 1)
                {
                    break;
                }
                char nextLetter = text[i + 1];
                while (currentLetter == nextLetter)//a=a
                {
                    text = text.Remove(i, 1);//qqqwerqwecccwd
                    currentLetter = text[i];
                    if (i == text.Length - 1)
                    {
                        break;
                    }
                    nextLetter = text[i + 1];
                }
            }
        }
    }
}
