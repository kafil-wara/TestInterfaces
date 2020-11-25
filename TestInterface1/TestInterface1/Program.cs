using System;

namespace TestInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalc b = new BasicCalc();
            ScientificCalc s = new ScientificCalc();

            b.sum(2, 3);
            b.multiplication(2, 3);

            s.XtoY(5, 2);

        }
    }
}
