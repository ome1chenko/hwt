using System;

namespace _01rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int recWidth = 3;
            int recHeight = 2;            
            int y = 0;
            
            while (y < recHeight)
            {
                int x = 0;
                while(x<recWidth)
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
