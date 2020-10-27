using Acme.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Infrastructure.Data.Repository
{

    //Singleton repository
    public sealed class SystemDB
    {
        private static readonly SystemDB instance = new SystemDB();

        public static List<Account> Courses { get; set; }

        static SystemDB()
        {

        }
        private SystemDB()
        {
            Courses = new List<Account> {
                new Account { Id = 1,AccountType ="savings", CustomerNumber= "Jack", Balance=2000 },
                new Account { Id = 2,AccountType ="savings", CustomerNumber= "Christina", Balance=5000 },
                new Account { Id = 3,AccountType ="current", CustomerNumber= "Stacey", Balance=1000  ,Overdraft =10000},
                new Account { Id = 4,AccountType ="current", CustomerNumber= "Genevieve", Balance=5000 , Overdraft=20000},
            };

        }
        public static List<Account> Instance
        {
            get
            {
                return Courses;
            }
        }

    }
}
