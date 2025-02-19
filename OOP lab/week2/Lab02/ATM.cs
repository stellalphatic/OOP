using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class ATM
    {
        private float balance = 0;
        List<string> transactions = new List<string>();
        public ATM()
        {

        }
        public ATM(float b)
        {
            balance = b;
        }
        public float checkBalance()
        {
            return balance;

        }
        public void deposit(float n)
        {
            balance += n;
            transactions.Add($"{n} dollars deposited");
        }
        public void withdraw(float n)
        {
            if (balance - n < 0)
                Console.WriteLine("You don't have enough balance");
            else
            {
                balance -= n;
                transactions.Add($"{n} dollars withdrawed");
            }
        }
    }
}
