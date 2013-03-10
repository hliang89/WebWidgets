using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoMvcApp.Models;
using ContosoMvcApp.ViewModels;

namespace ContosoMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private SchoolDBContext db = new SchoolDBContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Contoso University!";

            return View();
        }

        public ActionResult About()
        {
            var data = from s in db.Students
                       group s by s.EnrollmentDate into dateGroup
                       select new EnrollmentDateGroup()
                       {
                           EnrollmentDate = dateGroup.Key,
                           StudentCount = dateGroup.Count()
                       };

            return View(data);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
