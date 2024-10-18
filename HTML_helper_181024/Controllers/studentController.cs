using HTML_helper_181024.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;

namespace HTML_helper_181024.Controllers
{
    public class studentController : Controller
    {
        public ActionResult insertStudent()
        {
            MyStudentEntities mse = new MyStudentEntities();
            List<tblLanguage> courselist = mse.tblLanguages.ToList();
            ViewBag.langList=courselist;
            return View();
        }
        [HttpPost]
        public ActionResult insertStudent(tblStudent st)
        {
            MyStudentEntities mse1 = new MyStudentEntities();
            mse1.tblStudents.Add(st);
            int n = mse1.SaveChanges();
            if (n>0)
            {
                Response.Write("<script>alert('record inserted successfully...');</script>");
            }
            return RedirectToAction("insertStudent");
        }
        public ActionResult dropdowndemo()
        {
            List<string> courseList = new List<string>() { "java", "PHP", ".Net" };
            ViewBag.courseList = courseList;

            List<tblCourse> tblcourselist = new List<tblCourse>() {
             new tblCourse(){ id=1,course_name=".Net"},
                new tblCourse(){ id=2,course_name="JAVA"},
                new tblCourse(){ id=3,course_name="PHp"},
                new tblCourse(){ id=4,course_name="Python"},
                new tblCourse(){ id=5,course_name="mern Stack"},
            };
            ViewBag.tblcourselist = tblcourselist;

            return View();
        }
        [HttpPost]
        public ActionResult dropdowndemo(stud ss)
        {
            List<string> courseList = new List<string>() { "java", "PHP", ".Net" };
            ViewBag.courseList = courseList;

            return View();
        }
        // GET: student
        public ActionResult Index()
        {
            List<string> courseList = new List<string>() { "java", "PHP", ".Net" };
            ViewBag.courseList = courseList;
            return View();
        }
        [HttpPost]
        public ActionResult Index(stud s1)
        {
            List<string> courseList = new List<string>() { "java", "PHP", ".Net" };
            ViewBag.courseList = courseList;
            return View();
        }
        public ActionResult registration()
        {
            List<HTML_helper_181024.Models.tblCourse> courselist = new List<tblCourse>()
            {
                new tblCourse(){ id=1,course_name=".Net"},
                new tblCourse(){ id=2,course_name="JAVA"},
                new tblCourse(){ id=3,course_name="PHp"},
                new tblCourse(){ id=4,course_name="Python"},
                new tblCourse(){ id=5,course_name="mern Stack"},
            };
            ViewBag.tblCourseList = courselist;

            return View();
        }
        [HttpPost]
        public ActionResult registration(stud ss)
        {
            return View();
        }
        }
}