using Acme.Domain.Interfaces;
using Acme.Domain.Models;
using Acme.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Infrastructure.Data.Repository
{
   public class AccountRepository : IAccountRepository
    {

        
        private AccountsDBContext _ctx;
        //Not used since im using a singleton as rep
        public AccountRepository(AccountsDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return SystemDB.Instance;

            //return _ctx.Courses;
        }

  
    }
}
