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
            ViewData["Message"] = "  ";
            return View();
        }
    
       // Math Controller

        public IActionResult Arithmetics()
        {
            ViewData["Message"] = "Arithmetics";
            return View();
        }

        public IActionResult Differentiation()
        {
            ViewData["Message"] = "Differentiation";
            return View();
        }

        public IActionResult Functions()
        {
            ViewData["Message"] = "Functions";
            return View();
        }

        public IActionResult Geometry()
        {
            ViewData["Message"] = "Geometry";
            return View();
        }

        public IActionResult IntegralCalculus()
        {
            ViewData["Message"] = " Integral Calculus";
            return View();
        }

        public IActionResult Brazil()
        {
            ViewData["Message"] = "Brazil Literature";
            return View();
        }

        public IActionResult English()
        {
            ViewData["Message"] = "English Literature";
            return View();
        }

        public IActionResult French()
        {
            ViewData["Message"] = "French Literature";
            return View();
        }

        public IActionResult Italian()
        {
            ViewData["Message"] = "Italian Literature";
            return View();
        }

        public IActionResult SecuritiesLaw()
        {
            ViewData["Message"] = "SECURITIES LAW RESEARCH/ United States/ Federal & State";
            return View();
        }

        public IActionResult CorporationLaw()
        {
            ViewData["Message"] = "CORPORATIONS LAW RESEARCH/UNITED STATES";
            return View();
        }

        public IActionResult ManuscriptLaw()
        {
            ViewData["Message"] = "Manuscripts and Archives (Repository) Legal Subject Guide";
            return View();
        }

        public IActionResult Physics()
        {
            ViewData["Message"] = "";
            return View();
        }

        public IActionResult Chemistry()
        {
            ViewData["Message"] = "";
            return View();
        }

        public IActionResult Biology()
        {
            ViewData["Message"] = "";
            return View();
        }

        public IActionResult Algorithmsdatastructures()
        {
            ViewData["Message"] = "";
            return View();
        }

        public IActionResult Artificialintelligence()
        {
            ViewData["Message"] = "Artificial intelligence";
            return View();
        }

        public IActionResult Computerarchitecture()
        {
            ViewData["Message"] = "Computer architecture";
            return View();
        }

        public IActionResult Computergraphics()
        {
            ViewData["Message"] = "";
            return View();
        }

        public IActionResult Concurrentparallelanddistributedsystems()
        {
            ViewData["Message"] = "";
            return View();
        }


        public IActionResult MarketEnvironment()
        {
            ViewData["Message"] = "";
            return View();
        }


        public IActionResult BusinessHistory()
        {
            ViewData["Message"] = "";
            return View();
        }


        public IActionResult Economics()
        {
            ViewData["Message"] = "";
            return View();
        }
    }
}
