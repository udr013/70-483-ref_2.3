using System;
using System.Collections.Generic;
using System.Text;

namespace CreateAccessorMethods
{
    class OverDraftBankAccount: BankAccount
    {
        decimal overdraftLimit = 100;
        Address GuarantorAddress;

        public OverDraftBankAccount(int initialBalance) : base(initialBalance)
        {
        }

        public override bool WithDrawFunds(decimal amountToWithDraw)
        {
            if(amountToWithDraw > _accountBalance + overdraftLimit)
            {
                return false;
            }

            _accountBalance = _accountBalance - amountToWithDraw;
            return true;
        }

    }
}
