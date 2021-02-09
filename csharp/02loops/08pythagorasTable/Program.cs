using System;

namespace _08pythagorasTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int column;
            int row;
            int minRow;
            int maxRow;
            int minColumn;
            int maxColumn;
            int maxValue;            
            int cellWidth = 0;
            
            

            Console.WriteLine("Enter min value of row:");
            minRow = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter max value of row:");
            maxRow = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter min value of column:");
            minColumn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter max value of column:");
            maxColumn = Int32.Parse(Console.ReadLine());

            //Find cell width
            maxValue = maxRow*maxColumn;
            while (maxValue>0)
            {
                maxValue = maxValue/10;
                cellWidth++;                              
            }
            //Draw row header numbers
            Console.Write("|");
            for (int i = minRow; i<maxRow; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            
            //Draw row header line
            Console.WriteLine();
            for (int i = 0; i<(cellWidth*(maxRow-minRow));i++)
            {
            Console.Write('-');
            }

            //Draw values in table
            for (int i = minColumn; i<maxColumn; i++)
            {
                Console.WriteLine();
                for (int j = minRow; j<maxRow; j++)
                {
                    
                    
                    
                    
                    
                    Console.Write(i*j);
                    
                }
                
            }

                
        }
    }
}
