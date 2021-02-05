using System;

namespace EvenOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;

            Console.WriteLine("Enter a number:");
            enteredNumber = Int32.Parse(Console.ReadLine());

            if ((enteredNumber%2) == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            
        }
    }
}
