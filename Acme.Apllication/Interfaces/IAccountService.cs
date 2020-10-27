using Acme.Apllication.ViewModels;

using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Apllication.Interfaces
{
    public interface IAccountService
    {
        AccountViewModel GetAccounts();

    }
}
