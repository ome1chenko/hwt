using System;

namespace _05invertedUfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int trWidth = 3;           
            int y = 0;
            
            while (y <=trWidth)
            {               
                int a = 0;
                while(a<trWidth-(trWidth-y))
                {
                    Console.Write(" ");
                    a++;
                }   
                
                int b = 0;
                while(b<trWidth-y)
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
