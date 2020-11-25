using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface2
{
    class OverdraftAcc : Account, IBasicBanking
    {
        public OverdraftAcc() { }

        public OverdraftAcc(string name, string id, int balance) : base(name, id, balance) { }

        public int overDraftLimit = 500;
        public int overDraft = 0;

        public bool deposit(int amount)
        {
            Balance = Balance + amount;
            return true;
        }

        public bool withdraw(int amount)
        {
            if (amount >= Balance + overDraftLimit)
            {
                Console.WriteLine("Transaction Failed");
                return false;
            }
            
            else
            {
                Balance = Balance - amount;
                if (amount > Balance)
                    overDraft = amount - Balance;
                return true;
            }
        }
    }
}
