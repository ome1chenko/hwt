using System;

namespace _06tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int trWidth = 3;           
            int y = 0;
            int c = 0;
            
            while (y < trWidth)
            {               
                int a = 0;
                while(a<trWidth-y-1)
                {
                    Console.Write(" ");
                    a++;
                }   
                
                int b = 0;

                while(b<=y+c)
                {
                    Console.Write("*");
                    b++;
                }

                Console.WriteLine();
                y++;
                c=c+1; 
                 
            }  

            
             
        }
    }
}
