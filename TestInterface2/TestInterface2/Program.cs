using System;

namespace TestInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrentAcc c = new CurrentAcc("Kafil", "1111", 7500);
            c.withdraw(7500);
            c.showInfo();

            SavingsAcc s = new SavingsAcc("Walter", "2222", 10000);
            s.withdraw(8500);
            s.showInfo();

            OverdraftAcc o = new OverdraftAcc("Beth", "3333", 2500);
            o.withdraw(2700);
            o.showInfo();
        }
    }
}
