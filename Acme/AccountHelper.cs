using Acme.Apllication.Interfaces;
using Acme.Apllication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme
{
    public class AccountHelper
    {
        private ICourseService _courseService;
        public AccountHelper(ICourseService courseService)
        {
            _courseService = courseService;

        }

        public CourseViewModel Get()
        {
            return _courseService.GetCourses();


        }






    }
}
