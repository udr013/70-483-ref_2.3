using System;

namespace CreateAccessorMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount(10);
            account.PayInFunds(50);
            Console.WriteLine("account contains {0}", account.GetBalance());

            account.PayInFunds(50);
            Console.WriteLine("account contains {0}", account.GetBalance());

            if (account.WithDrawFunds(10))
            {
                Console.WriteLine(account.GetBalance());
            }
            account.WithDrawFunds(100);

            BankAccount overDraftBankAccount = new OverDraftBankAccount(20);
            overDraftBankAccount.PayInFunds(100);
            overDraftBankAccount.WithDrawFunds(130);
            Console.WriteLine("account contains {0}", overDraftBankAccount.GetBalance());

            overDraftBankAccount.SetAddress("bla");
            Console.WriteLine("account for {0}", overDraftBankAccount.GetAddress());

        }
    }
}
