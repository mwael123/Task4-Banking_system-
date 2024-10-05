using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_management_system
{
    public class Savings_Account :Account
    {
        public Savings_Account(string name,double balance =0,double _intRate=0)
           :base(name,balance) 
        {

            this.IntRate = _intRate;
        }
        public Savings_Account()
           
        {

            
        }



        public double IntRate { get; set; }
    }
}
