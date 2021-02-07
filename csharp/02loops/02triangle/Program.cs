using System;

namespace _02triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int trWidth = 3;           
            int y = 0;
            
            while (y < trWidth)
            {
                int x = 0;
                while(x<=y)
                {
                    Console.Write("*");
                    x++;
                }
                Console.WriteLine();
                y++;  
            }     
            
        }
    }
}
