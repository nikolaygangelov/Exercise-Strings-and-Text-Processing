

namespace _5.__Multiply_Big_Number
{
    using System;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {

            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            int productFirstDigit = 0;

            if(multiplier == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int product = multiplier * currentDigit + productFirstDigit;
                productFirstDigit = product / 10;
                
                if (product >= 10)
                {
                    int productSecondDigit = product % 10;
                    sb.Insert(0, productSecondDigit);
                    if(i == 0)
                    {
                        sb.Insert(0, productFirstDigit);
                    }

                }
                else if (product < 10)
                {
                    sb.Insert(0, product);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
