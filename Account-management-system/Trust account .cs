using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_management_system
{
      public class Trust_account : Savings_Account
    {
        public double Bonus {  get; }
        public int withdrawals_per_Year = 0;
        public int Max_Withdrawal = 3;  
        public double MaxWithdrawalPercentage = 0.2;
        public Trust_account(string _name, double _balance=0, double _intRate = 0, double _Bonus = 50.00) : base(_name, _balance, _intRate)
        {

            this.Bonus = _Bonus;

        }
        public Trust_account()
        {

            

        }


        public new bool Deposit(double amount)
        {
            if (amount < 0)
            {
                return false;
            }
            else if (amount >= 5000.00)
            {
                balance += amount + Bonus;
            }
            else
            {
                balance += amount; 
            }
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (withdrawals_per_Year >= Max_Withdrawal)
            {
                Console.WriteLine("Withdrawal limit Reached");
                return false;
            }

            double max_Allow_Withdrawal = balance * MaxWithdrawalPercentage;

            if (amount > max_Allow_Withdrawal)
            {
                Console.WriteLine($" You can  withdraw up to 20% only of your balance: {max_Allow_Withdrawal}");
                return false;
            }

            if (balance < amount)
            {
                Console.WriteLine("balance is Insufficient ");
                return false;
            }

            balance -= amount;
            withdrawals_per_Year++;
            Console.WriteLine($"Withdrawal successful.  {Max_Withdrawal - withdrawals_per_Year} Remaining times this year");
            return true;
        }

    }


   
}
