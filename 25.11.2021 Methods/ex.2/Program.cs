using System;

namespace ex._2
{
    internal class Program
    {
        static bool CheckPassword(string password, string repeatPassword)
        {
            return (password == repeatPassword);
        }

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string repeatPassword = Console.ReadLine();

            if (CheckPassword(password, repeatPassword))
                Console.WriteLine("The passwords match");

            else
                Console.WriteLine("The passwords don't match");
        }
    }
}
