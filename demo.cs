using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Demo
    {
        static public void Hello()
        {
            Console.WriteLine("Xin chao C# \n");
        }
        public static int Max(int a, int b)
        {
            int max = (a > b) ? a : b;
            return max;
        }

        public static long TheTich(int c, int d = 23, int e = 12)
        {
            return c * d * e;
        }
    }

}
