using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface1
{
    class ScientificCalc : IBasicCalc, IScientificCalc
    {
        public ScientificCalc() { }

        public int multiplication(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
            return result;
        }

        public int sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
            return result;
        }

        public int division(int x, int y)
        {
            int result = x / y;
            Console.WriteLine(result);
            return result;
        }

        public int sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
            return result;
        }

        public int XtoY(int x, int y)
        {
            int result = (int)Math.Pow(x, y);
            Console.WriteLine(result);
            return result;
        }
    }
}
