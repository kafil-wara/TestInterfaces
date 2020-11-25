using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface2
{
    class SavingsAcc : Account, IBasicBanking
    {
        public SavingsAcc() { }

        public SavingsAcc(string name, string id, int balance) : base(name, id, balance) { }







        public bool deposit(int amount)
        {
            Balance = Balance + amount;
            return true;
        }

        public bool withdraw(int amount)
        {
            if (amount > (Balance / 100 * 80))
            {
                Console.WriteLine("Transaction Failed");
                return false;
            }
            else
            {
                Balance = Balance - amount;
                return true;
            }
                
        }
    }
}
