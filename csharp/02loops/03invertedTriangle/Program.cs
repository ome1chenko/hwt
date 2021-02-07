using System;

namespace _03invertedTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int trWidth = 3;           
            int y = 0;
            
            while (y < trWidth)
            {               
                int a = 0;
                while(a<trWidth-y-1)
                {
                    Console.Write(" ");
                    a++;
                }   
                
                int b = 0;
                while(b<=y)
                {
                    Console.Write("*");
                    b++;
                }

                Console.WriteLine();
                y++;  
            }     
        }
    }
}
