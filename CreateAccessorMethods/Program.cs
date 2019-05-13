using System;
using System.Collections.Generic;

namespace CreateAccessorMethods
{
    class Program
    {
        static void Main(string[] args)
        {

           IAccount account = new BankAccount(10);
            account.PayInFunds(50);
            Console.WriteLine("account contains {0}", account.GetBalance());

            account.PayInFunds(50);
            Console.WriteLine("account contains {0}", account.GetBalance());

            if (account.WithdrawFunds(10))
            {
                Console.WriteLine(account.GetBalance());
            }
            account.WithdrawFunds(100);

            //how to fix this?
            IAccount overDraftBankAccount = new OverDraftBankAccount(20);
            overDraftBankAccount.PayInFunds(100);
            overDraftBankAccount.WithdrawFunds(130);
            Console.WriteLine("account contains {0}", overDraftBankAccount.GetBalance());

            //overDraftBankAccount.SetAddress("bla");
            //Console.WriteLine("account for {0}", overDraftBankAccount.GetAddress());

            List<IAccount> accounts = new List<IAccount>();
            Random random = new Random();
            for(int i = 0; i < 20; i++)
            {
                IAccount someaccount = new BankAccount(random.Next(0, 1000));
                accounts.Add(someaccount);
            }

            accounts.Sort();

            Console.WriteLine("Sorted accounts");
            foreach(IAccount acc in accounts)
            {
                Console.WriteLine(acc.GetBalance());
            }

        }
    }
}
