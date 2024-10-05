using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_management_system
{
    public  class Account
    {
        public Account(string name, double balance = 0)
        {
            this.name = name;
            this.balance = balance ;
        }

        public Account()
        {


        }

        public string name { get; set; }
        public double balance { get; set; }


        public static Account operator+ (Account L, Account R)
        {

            Account account = new() {name=L.name , balance= L.balance+R.balance };
            return account;

        }


        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }

        public bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance()
        {
            return balance;
        }


    }
}
