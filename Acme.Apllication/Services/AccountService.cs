using Acme.Apllication.Interfaces;
using Acme.Apllication.ViewModels;
using Acme.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Apllication.Services
{
    public class AccountService : IAccountService
    {

        private IAccountRepository _courseRepository;

        public AccountService(IAccountRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public AccountViewModel GetAccounts()
        {
            return new AccountViewModel()
            {
                Courses = _courseRepository.GetAccounts()

            };
        }
    }
}
