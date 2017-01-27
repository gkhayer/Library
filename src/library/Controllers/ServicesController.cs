using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{
    public class ServicesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult WestVirginiaSurvey()
        {
            ViewData["Message"] = "";

            return View();
        }
    
        public IActionResult ConsultingServices()
        {
            ViewData["Message"] = " ";

            return View();
        }
    
        public IActionResult ContinuingEducation()
        {
            ViewData["Message"] = " ";

            return View();
        
          }

        public IActionResult Compliance()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult ResearchAssistance()
        {
            ViewData["Message"] = " ";

            return View();
        }

        public IActionResult ResearchTools()
        {
            ViewData["Message"] = " ";

            return View();
        }

        public IActionResult Support()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult FacilitiesandEquipment()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult AmericaStoryfromAmericaLibrary()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult BorrowerCard()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult LettersaboutLiterature()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult WestVirginiaCenterfortheBook()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult Collections()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult DatabasesandResources()
        {
            ViewData["Message"] = " ";

            return View();
        }
        public IActionResult LibraryLocatorMap()
        {
            ViewData["Message"] = " ";

            return View();
        }
             public IActionResult SpecialServicesLibraryforBlindandPhysicallyHandicapped()
        {
            ViewData["Message"] = " ";

            return View();
        }
    }
}

