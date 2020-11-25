using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface1
{
    class BasicCalc : IBasicCalc
    {
        public BasicCalc() { }


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
    }
}
