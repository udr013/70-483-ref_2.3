using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAccessorMethods
{
    class BankAccount
    {
        //inner class
        protected class Address
        {
            public string FirstLine;
            public string Postcode;
        }


        protected decimal _accountBalance = 0;
        protected Address address = new Address();

        public void PayInFunds(decimal amountToPayIn)
        {
            _accountBalance = _accountBalance + amountToPayIn;
        }

        public virtual bool WithDrawFunds(decimal amountToWithdraw)
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

        public decimal GetBalance()
        {
            return _accountBalance;
        }

        public string GetAddress()
        {
            return address.Postcode;
        }
    }
}
