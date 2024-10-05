using Account_management_system;
using System;
using System.Collections.Generic;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        // Accounts
        Account account2 = new Account();
        Account account3 = new Account();
        Account account1 = account2 + account3;
        var accounts = new List<Account>();
        accounts.Add(new Account());
        accounts.Add(new Account("Larry"));
        accounts.Add(new Account("Moe", 2000));
        accounts.Add(new Account("Curly", 5000));

        AccountUtil.Display(accounts);
        AccountUtil.Deposit(accounts, 1000);
        AccountUtil.Withdraw(accounts, 2000);

        // Savings
        
        accounts.Add(new Savings_Account());                       
        accounts.Add(new Savings_Account("Superman"));             
        accounts.Add(new Savings_Account("Batman", 2000));          
        accounts.Add(new Savings_Account("Wonderwoman", 5000, 5.0));
        AccountUtil.Display(accounts);
        AccountUtil.Deposit(accounts, 1000);  
        AccountUtil.Withdraw(accounts, 2000); 

        // Checking
        
        accounts.Add(new Checking_account());
        accounts.Add(new Checking_account("Larry2"));
        accounts.Add(new Checking_account("Moe2", 2000));
        accounts.Add(new Checking_account("Curly2", 5000));

        AccountUtil.Display(accounts);
        AccountUtil.Deposit(accounts, 1000);
        AccountUtil.Withdraw(accounts, 2000);
        AccountUtil.Withdraw(accounts, 2000);

        // Trust
        
        accounts.Add(new Trust_account());
        accounts.Add(new Trust_account("Superman2"));
        accounts.Add(new Trust_account("Batman2", 2000));
        accounts.Add(new Trust_account("Wonderwoman2", 5000, 5.0));

        AccountUtil.Display(accounts);
        AccountUtil.Deposit(accounts, 1000);
        AccountUtil.Deposit(accounts, 6000);
        AccountUtil.Withdraw(accounts, 2000);
        AccountUtil.Withdraw(accounts, 3000);
        AccountUtil.Withdraw(accounts, 500);

        Console.WriteLine();
    }
}