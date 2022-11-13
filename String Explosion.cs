using System;

namespace _7.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int explosionStrength = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                char currentLetter = text[i];
                char nextLetter = text[i + 1];

                if (currentLetter == '>')
                {
                    explosionStrength += int.Parse(nextLetter.ToString());
                    while (explosionStrength > 0 && nextLetter != '>')
                    {
                        text = text.Remove(i + 1, 1);
                        explosionStrength--;
                        if (i == text.Length - 1)
                        {
                            break;
                        }
                        nextLetter = text[i + 1];
                    }
                    
                }
            }
            Console.WriteLine(text);
        }
    }
}
