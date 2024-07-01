using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {


        public IActionResult Index()
        {
            // return Content("index");
            return View();
        }

        public IActionResult Detail(int id)
        {
            return View();
        }


    }
}