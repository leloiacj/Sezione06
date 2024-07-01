using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyCourse.Controllers
{
    [Route("[controller]")]
    public class CoursesController : Controller
    {


        public IActionResult Index()
        {
            return Content("index");
        }

        public IActionResult Detail(int id)
        {
            return Content($"sono detail e ho id {id}");
        }


    }
}