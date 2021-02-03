using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 7;
            int d = 10;
            int e = 1;
            int f = 12;
            int h = 2;
            int max = -1;

            if (a > b)
            {
                max = a;
            }
            if (b > a)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }
            if (max < e)
            {
                max = e;
            }
            if (max < f)
            {
                max = f;
            }
            if (max < h)
            {
                max = h;
            }
            Console.WriteLine("Max number:" + max);
        }
    }
}
