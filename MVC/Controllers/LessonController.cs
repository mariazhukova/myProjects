using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class LessonController : Controller
    {
        private MVCContext db = new MVCContext();
        private static List<LessonItemViewModel> lessons = null;   
      

        public LessonController()
        {
            lessons = new List<LessonItemViewModel>
            {
            new LessonItemViewModel { ID = 1, Group = "English Basic", Room = "3.301", Trainer = "Татьяна Борисовна", HomeWork = "1книга 5,6,7 упражнение",DateTime=DateTime.Now },
            new LessonItemViewModel { ID = 2, Group = "English Elementary", Room = "3.312", Trainer = "Татьяна Борисовна", HomeWork = "Граматика 3 упражнение",DateTime=DateTime.Now }
            };
        }

        // GET: LessonItemViewModels
        [HttpGet]
        public ActionResult Index()
        {
            return View(lessons);
            
        }

        [HttpGet]
        public ActionResult Lessons()
        {
            return View(lessons);
        }

        // GET: LessonItemViewModels/Details/5
        [HttpGet]
        [ActionName("Details")]
        public ActionResult Details(int id)
        {

            ViewBag.ViewType = "View";
            return GetLesson(id);
         
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult EditLesson(int id)
        {
            ViewBag.ViewType = "Edit";
            return GetLesson(id);
        }

        [HttpPost]
        [ActionName ("Edit")]
        public ActionResult EditLesson(LessonItemViewModel lesson)
        {
            ViewBag.ViewType("Edit");

            if (!ModelState.IsValid)
                return View("Details", lesson);
            return RedirectToAction("Index");


        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult CreateLesson()
        {
            ViewBag.ViewType = "Create";
            var lesson = new LessonItemViewModel
            {
                ID = lessons.Max(l => l.ID) + 1,
                DateTime = DateTime.Now
            };
           
            return View("Details",lesson);
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult CreateLesson(LessonItemViewModel lesson)
        {
            ViewBag.ViewType("Create");

            if (!ModelState.IsValid)
                return View("Details", lesson);

            lesson.ID = lessons.Max(l => l.ID) + 1;
            lesson.DateTime = DateTime.Now;
            lessons.Add(lesson);
            return RedirectToAction("Index");


        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var lesson = lessons.FirstOrDefault(l => l.ID == id);
            if (lesson == null)
                return RedirectToAction("Index");
            lessons.Remove(lesson);
            return View("Index",lessons);
        }

        private ActionResult GetLesson(int id)
        {
            var lesson = lessons.FirstOrDefault(l => l.ID == id);
            if (lesson == null)
                return RedirectToAction("Index");
            return View("Details",lesson);

        }
        // GET: LessonItemViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
