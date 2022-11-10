using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < usernames.Length; i++)
            {
                bool isValid = true;
                string currentUsername = usernames[i];
                if (currentUsername.Length < 3 || currentUsername.Length > 16)
                {
                    continue;
                }

                for (int j = 0; j < currentUsername.Length; j++)
                {

                    if (!char.IsLetterOrDigit(currentUsername[j]))
                    {
                        
                        if ((int)currentUsername[j] != 95 && (int)currentUsername[j] != 45)
                        {
                            isValid = false;
                            
                        }
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(currentUsername);
                }
            }
        }
    }
}
