using System;

namespace _07diamond
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

            y = 0;
            c = c-4;

            while (y < trWidth-1)
            {             
                int a = 0;
                while(a<=y)
                {
                    Console.Write(" ");
                    a++;
                }   
                
                int b = 0;
                while(b<=trWidth-y+c)
                {
                    Console.Write("*");
                    b++;
                }

                Console.WriteLine();
                y++;
                c=c-1;               
            }  
        }
    }
}
