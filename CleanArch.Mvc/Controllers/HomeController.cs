using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Acme.Mvc.Models;
using Acme.Apllication.Interfaces;
using Acme.Apllication.ViewModels;
using Acme.Domain.Models;

namespace Acme.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IAccountService _courseService;

        private AccountViewModel _courses;

        public HomeController(ILogger<HomeController> logger, IAccountService courseService)
        {
            _logger = logger;

            _courseService = courseService;

            _courses = _courseService.GetAccounts();
        }





        public IActionResult Index()
        {

            return View(_courses);
        }

        [HttpPost]
        public IActionResult Index(Account course)
        {
            if (course.Deposit != 0)
            {
                _courses.Courses.FirstOrDefault(a => a.Id == course.Id).MakeDeposit(course);
            }
            if (course.Withdraw != 0)
            {
                _courses.Courses.FirstOrDefault(a => a.Id == course.Id).MakeWithdrawal(course);
            }

            return View(_courses);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
