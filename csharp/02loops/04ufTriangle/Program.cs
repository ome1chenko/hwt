using System;

namespace _04ufTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int trWidth = 3;           
            int y = 0;
            
            while (y <= trWidth)
            {
                int x = 0;
                while(x<trWidth - y)
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
