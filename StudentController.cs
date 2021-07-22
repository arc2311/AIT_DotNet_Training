using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student stud = new Student();
            stud.Name = "John";
            stud.Age = 15;
            stud.Gender = "Male";

            ViewBag.StudentObj = stud;

            return View();
        }

        public IActionResult ViewDataExample()
        {
            Student stud1 = new Student();
            stud1.Name = "Archana";
            stud1.Age = 25;
            stud1.Gender = "Female";

            ViewData["StudObj"] = stud1;
            return View();

        }
        public IActionResult TempDataExample()
        {
            TempData["StudObj1"] = "Archana";
            return View();

        }

        public IActionResult SendSimpleString()
        {
            string welcomeMsg = "Welcome to MVC Example";
            return View((object)welcomeMsg);
        }

        public IActionResult SendObject()
        {
            Student stud2 = new Student();
            stud2.Name = "Mahesh";
            stud2.Age = 23;
            stud2.Gender = "Male";

            return View(stud2);
        }
        public IActionResult SendListObject()
        {
            List<Student> list = new List<Student>();
            Student s = new Student();
            s.Name = "Kajal";
            s.Age = 26;
            s.Gender = "Female";

            Student s1 = new Student();
            s1.Name = "Dinesh";
            s1.Age = 23;
            s1.Gender = "Male";
            list.Add(s);
            list.Add(s1);

            return View(list);
        }
    }
}