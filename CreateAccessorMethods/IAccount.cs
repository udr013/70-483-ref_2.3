using System;

namespace CreateAccessorMethods
{
    internal interface IAccount : IComparable<IAccount>
    {
        void PayInFunds(decimal amount);
        decimal GetBalance();
        bool WithdrawFunds(decimal amountToWithdraw);
    }
}