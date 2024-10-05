using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_management_system
{
     class Checking_account :Account

    {
        public Checking_account(string name , double balance=0, double _fee=1.50)
            :base(name,balance)
        {
           this. Fee = _fee;
        }

        public Checking_account()
            
        {
            
        }

        public double Fee { get; set; }



        public new bool Withdraw(double amount)
        {
            return base.Withdraw(amount+Fee);
        } 
    }
}
