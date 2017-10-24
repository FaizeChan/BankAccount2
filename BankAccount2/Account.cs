using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class Accounts
    {

        protected double viewBalance;


        public double ViewBalance { get; set; }

        public string AccountType { get; set; }

        public virtual void Balance()
        {

        }


        public virtual double Withdraw(double withdrawingAmount)
        {
            viewBalance -= withdrawingAmount;
            return viewBalance;
        }

        public virtual double Deposit(double depositAmount)
        {
            viewBalance += depositAmount;
            return viewBalance;
        }
    }
}