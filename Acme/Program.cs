using Acme.Apllication.Interfaces;
using System;

namespace Acme
{
    class Program
    {

        private static ICourseService _courseService;

        public Program(ICourseService courseService)
        {
            _courseService = courseService;
        }

        static void Main(string[] args)
        {

            AccountHelper accountHelper = new AccountHelper(_courseService);


            Console.WriteLine("Hello World!");
        }
    }
}
