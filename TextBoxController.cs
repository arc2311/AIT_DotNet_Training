using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{
    public class TextBoxController : Controller
    {
        [HttpGet]
        public IActionResult GetTextBoxValue()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult GetTextBoxValue(string name) //for single textbox
        //{
        //    return View("Display", (object)name);
        //}
        [HttpPost]
        public IActionResult GetTextBoxValue(IFormCollection fc)
        {
            string name = fc["name"].ToString();
            //string lname = fc["lname"].ToString();

            return View("Display", (object)name);
            // return View();
        }


    }
}