using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount2
{
    class Checking : Accounts
    {

        public double checkingBase;

        public double CheckingBase { get; set; }

        //My set starting balance
        public Checking()
        {
            this.checkingBase = 2500.00;
        }
            
            
        //So that in the output itll add the set balance i made(5000) and add it to ammount deposited or withdrawn.
        public override void Balance()
        {
            base.Balance(); Console.WriteLine("Checking Balance is now $" + (viewBalance + checkingBase));
        }



    }
}