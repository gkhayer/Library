using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{

    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            ViewData["Message"] = "This the your home page";
            return View();
        }
    }
}
