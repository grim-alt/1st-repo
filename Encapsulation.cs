using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Account
    {
        private int balance;
        public void SetBalance(int amount)
        {
            if (amount >= 0)
                balance = amount;
        }
        public int GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main()
        {
            Account acc = new Account();

            acc.SetBalance(5000);
            Console.WriteLine("Balance: " + acc.GetBalance());
        }
    }
}
