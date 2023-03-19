using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05.Classes
{
    public class Account
    {
        public bool Withdraw(double amount, double balance)
        {
            if (balance >= amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Deposit(double amount, double balance)
        {
            return balance + amount;
        }
    }

}
