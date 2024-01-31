using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC_Course.Models;

namespace WebAppMVC_Course.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> courses = new List<Course>()
        {
            new Course() { CId=1,CName="Rashmi",CFee=12000,Technology=".Net",CStartDate=new DateTime(01/10/2023),CEndDate=new DateTime(25/10/2023) },
            new Course() { CId=2,CName="RashmiPriya",CFee=15000,Technology="JAVA",CStartDate=new DateTime(01/01/2023),CEndDate=new DateTime(25/09/2023) },
            new Course() { CId=3,CName="Priya",CFee=17000,Technology="PYTHON",CStartDate=new DateTime(01/10/2023),CEndDate=new DateTime(25/11/2023) }

        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                courses.Add(course);
                return RedirectToAction("Index");

            }
            return View(course);
        }
    }
}