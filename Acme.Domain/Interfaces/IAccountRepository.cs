using Acme.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();

    }

    public interface IAccountServices
    {
        //public void openSavingsAccount(Long accountId, Long amountToDeposit);
        //public void openCurrentAccount(Long accountId);
        public void MakeWithdrawal(Account action);
        //throws AccountNotFoundException, WithdrawalAmountTooLargeException;
        public void MakeDeposit(Account action);
        //throws AccountNotFoundException;
    }
}
