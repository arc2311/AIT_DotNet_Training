using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("Emp")]//controller level routing
    public class EmployeeController : Controller
    {
        [Route("Show")]//action method level routing
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Name = "Hello Archana";

            return View();
        }

        // GET: Employee/Details/5
       
    }
}