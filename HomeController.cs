using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(VaryByHeader ="User-Agent",Duration =30)]
        public ActionResult Index()
        {
            ViewBag.Dt = DateTime.Now.ToString("MM/YY HH:mm:ss");

            //return View();
            List<User> obj = new List<User>();
            obj.Add(new User() { Id = 101, Name = "Archana" });
            obj.Add(new User() { Id = 102, Name = "Neha" });
            obj.Add(new User() { Id = 103, Name = "Tejal" });

            ViewData["UserName"] = obj;

            return View(obj);
        }
        public ViewResult ViewR()
        {
            return View();
        }
        public JsonResult JsonR()
        {
            // object data = null;
            string[] str = { "ABC", "BFR", "RTY", "QWE" };
            //return Json(data);
            return Json(str);
        }

        public FileContentResult FileContentRe()
        {
            var downloadFile = System.IO.File.ReadAllBytes("wwwroot/Email_Assignment.pdf");

            return new FileContentResult(downloadFile, "application/pdf");
        }
      
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
