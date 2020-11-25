using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface2
{
    abstract class Account 
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Balance { get; set; }

        public Account() { }

        public Account(string name, string id, int balance)
        {
            Name = name;
            Id = id;
            Balance = balance;
        }

        public void showInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Balance: " + Balance + Environment.NewLine);
        }

        
    }
}
