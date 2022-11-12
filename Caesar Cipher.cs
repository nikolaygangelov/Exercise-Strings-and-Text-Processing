using System;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int newUnicode = (int)currentChar + 3;

                char newChar = (char)newUnicode;

                Console.Write(newChar);
            }

        }
    }
}
