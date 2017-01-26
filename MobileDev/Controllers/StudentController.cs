using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileDev.Models;

namespace MobileDev.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult studentInfo()
        {
            studentDetails newStud = new studentDetails();

            newStud.Name = "Nathan Mante";
            newStud.sNumber = "N01089246";
            newStud.program = "Web Development";

            return View(newStud);
        }
    }
}