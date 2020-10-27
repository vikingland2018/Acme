using Acme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Infrastructure.Data.Context
{
    public class AccountsDBContext : DbContext
    {
        public AccountsDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }


    }
}
