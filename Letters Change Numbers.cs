

namespace _8.__Letters_Change_Numbers
{
    using System;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);//A12b s17G

            decimal result = 0;
            decimal number = 0;
            foreach (string currentString in text)//A12b
            {
                var sb = new StringBuilder();
                sb.Append(currentString[1]);
                char letterAfterNumber = '\0';//b

                if (char.IsDigit(currentString[2]))
                {
                    int indexOfNumber = 2;
                    while (char.IsDigit(currentString[indexOfNumber]))
                    {
                        sb.Append(currentString[indexOfNumber]);
                        indexOfNumber++;
                    }
                    letterAfterNumber = currentString[indexOfNumber];
                }
                else
                {
                    letterAfterNumber = currentString[2];
                }

                number = int.Parse(sb.ToString());
                char letterBeforeNumber = currentString[0];//A

                if (char.IsUpper(letterBeforeNumber))
                {
                    int positionInAlphabet = (int)letterBeforeNumber - 64;
                    number /= positionInAlphabet;
                }
                else if (char.IsLower(letterBeforeNumber))
                {
                    int positionInAlphabet = (int)letterBeforeNumber - 96;
                    number *= positionInAlphabet;
                }

                if (char.IsUpper(letterAfterNumber))
                {
                    int positionInAlphabet = (int)letterAfterNumber - 64;
                    number -= positionInAlphabet;
                }
                else if (char.IsLower(letterAfterNumber))
                {
                    int positionInAlphabet = (int)letterAfterNumber - 96;
                    number += positionInAlphabet;
                }
                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
