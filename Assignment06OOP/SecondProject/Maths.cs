using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP.SecondProject
{
    internal static class Maths
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static double devide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return x / y;
        }
    }
}
