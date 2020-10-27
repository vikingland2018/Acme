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
}
