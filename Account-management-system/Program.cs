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
        var savAccounts = new List<Account>();
        savAccounts.Add(new Savings_Account());
        savAccounts.Add(new Savings_Account("Superman"));
        savAccounts.Add(new Savings_Account("Batman", 2000));
        savAccounts.Add(new Savings_Account("Wonderwoman", 5000, 5.0));

        AccountUtil.Display(savAccounts);
        AccountUtil.Deposit(savAccounts, 1000);
        AccountUtil.Withdraw(savAccounts, 2000);

        // Checking
        var checAccounts = new List<Account>();
        checAccounts.Add(new Checking_account());
        checAccounts.Add(new Checking_account("Larry2"));
        checAccounts.Add(new Checking_account("Moe2", 2000));
        checAccounts.Add(new Checking_account("Curly2", 5000));

        AccountUtil.Display(checAccounts);
        AccountUtil.Deposit(checAccounts, 1000);
        AccountUtil.Withdraw(checAccounts, 2000);
        AccountUtil.Withdraw(checAccounts, 2000);

        // Trust
        var trustAccounts = new List<Account>();
        trustAccounts.Add(new Trust_account());
        trustAccounts.Add(new Trust_account("Superman2"));
        trustAccounts.Add(new Trust_account("Batman2", 2000));
        trustAccounts.Add(new Trust_account("Wonderwoman2", 5000, 5.0));

        AccountUtil.Display(trustAccounts);
        AccountUtil.Deposit(trustAccounts, 1000);
        AccountUtil.Deposit(trustAccounts, 6000);
        AccountUtil.Withdraw(trustAccounts, 2000);
        AccountUtil.Withdraw(trustAccounts, 3000);
        AccountUtil.Withdraw(trustAccounts, 500);

        Console.WriteLine();
    }
}
