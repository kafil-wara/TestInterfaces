using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface2
{
    public interface IBasicBanking
    {
        bool deposit(int amount);

        bool withdraw(int amount);
    }
}
