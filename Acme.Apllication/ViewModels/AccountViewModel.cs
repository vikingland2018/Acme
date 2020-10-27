using Acme.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Apllication.ViewModels
{
    public class AccountViewModel
    {
        public IEnumerable<Account> Courses { get; set; }
    }
}
