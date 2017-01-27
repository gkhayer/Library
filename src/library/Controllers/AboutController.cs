using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using library.Data;
using library.Models.SchoolViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{
    
    public class AboutController : Controller
    {
        private readonly SchoolContext _context;

        public AboutController(SchoolContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            IQueryable<EnrollmentDateGroup> data =
                from student in _context.Students
                group student by student.EnrollmentDate into dateGroup
                select new EnrollmentDateGroup()
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
        }

       /*public IActionResult Index()
        {
            ViewData["Message"] = "";

            return View();
        }*/

        public IActionResult MissionandStrategicPlan()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult LawsandRegulations()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult Commissioners()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult StaffDirectory()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult EmploymentOpportunities()
        {
            ViewData["Message"] = "";

            return View();
        }
        public IActionResult WebsitePolicies()
        {
            ViewData["Message"] = "";

            return View();
        }
    }
}
