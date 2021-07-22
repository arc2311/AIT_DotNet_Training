using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ErrorTest()
        {
            string i = "a";
            int x = Convert.ToInt32(i);
            return View();
        }
    }
}