using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAccessorMethods
{
    class BankAccount: IAccount
    {
        //inner class
        protected class Address
        {
            public string FirstLine;
            public string Postcode;
        }

        protected decimal _accountBalance = 0;
        protected Address address = new Address();

        public BankAccount(int initialBalance)
        {
            this._accountBalance = initialBalance;
        }
        void IAccount.PayInFunds(decimal amountToPayIn)
        {
            _accountBalance = _accountBalance + amountToPayIn;
        }

        public bool WithdrawFunds(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _accountBalance)
            {
                Console.WriteLine("unable to withDraw {0} current balance {1}", amountToWithdraw, _accountBalance);
                return false;
            }

            _accountBalance = _accountBalance - amountToWithdraw;
            return true;
        }

        internal void SetAddress(string v)
        {
            address.Postcode = v;
        }

        decimal IAccount.GetBalance()
        {
            return _accountBalance;
        }

        public string GetAddress()
        {
            return address.Postcode;
        }

        public int CompareTo(IAccount account)
        {
            if (account == null)
           {
                throw new ArgumentException("Object is not an account");
            }

                   return this._accountBalance.CompareTo(account.GetBalance());
        }

        public int CompareTo(BankAccount other)
        {
            throw new NotImplementedException();
        }

        //public int CompareTo(object obj)
        //{
        //   if(obj == null)
        //    {
        //        return 1;
        //    }

        //    IAccount account = obj as IAccount;

        //    if (account == null)
        //    {
        //        throw new ArgumentException("Object is not an account");
        //    }

        //    return this._accountBalance.CompareTo(account.GetBalance());
        //}
    }
}
