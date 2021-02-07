using System;

namespace BuyElephant
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string choice;

            Console.WriteLine("Hello! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Well hello, " + name);
            Console.WriteLine("Wanna buy some elephant? (Yes/No)");
            choice = Console.ReadLine();
            if (choice == "Yes" || choice == "yes")
            {
                Console.WriteLine("Relax man, just a joke");
            }
            else if (choice == "No" || choice == "no")
            {
                Console.WriteLine($"Everyone says \"{choice}\", but you buy");
            }
        }
    }
}
