using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface2
{
    class CurrentAcc : Account, IBasicBanking
    {
        public CurrentAcc() { }

        public CurrentAcc(string name, string id, int balance) : base(name, id, balance) { }

        public bool deposit(int amount)
        {
            Balance = Balance + amount;
            return true;
        }

        public bool withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance = Balance - amount;
                return true;
            }
            else
                return false;
        }
    }
}
