using Acme.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Acme.Domain.Models
{
    public class Account: IAccountServices
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        //This could be an Enum or I could inherit from an account class and split saving and current
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public decimal Overdraft { get; set; }
        public decimal Deposit { get; set; }
        public decimal Withdraw { get; set; }
        public string Message { get; set; }

        public void MakeDeposit(Account action)
        {
            //Always accept positive numbers
            action.Deposit = Math.Abs(action.Deposit);
            if (action.Deposit > 0)
            {
                Balance += action.Deposit;
            }

            Message = "Deposited";
        }

        public void MakeWithdrawal(Account action)
        {
            Message = "Done.";

            //SAVINGS
            //Always accept positive numbers
            action.Withdraw = Math.Abs(action.Withdraw);

            if (AccountType == "savings")
            {
                //if is `saving and above the 1000 val then subtract
                if ((Balance - action.Withdraw) >= 1000)
                {
                    Balance -= action.Withdraw;
                }
                else
                {
                    Message = "Cannot withdraw, Saving must always have at least 1000";
                }
            }

            //CURRENT
            if (AccountType == "current")
            {
                //can still draw money
                if ((Balance + Overdraft) >= action.Withdraw)
                {
                    Balance -= action.Withdraw;

                }
                else
                {
                    Message = "You cannot draw more than the overdraft";
                }
            }

        }

    }
}
