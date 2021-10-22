using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tq.Intranet.Web.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            
            return View();
        }
        public FileResult File()
        {
            return File(AppDomain.CurrentDomain.BaseDirectory + "Content/PF Report.pdf", "application/pdf");
        }
       public ActionResult Empty()
        {
            List<Models.Employee> empList = new List<Models.Employee>()
            {
                new Models.Employee(){Name ="Aniket", Id = 1, FieldExperience = 12},
                new Models.Employee(){Name ="Rupali", Id = 2, FieldExperience = 13},
                new Models.Employee(){Name ="Bhavika", Id = 3, FieldExperience = 14},
                new Models.Employee(){Name ="Vivek", Id = 4, FieldExperience = 15},
                new Models.Employee(){Name ="Abhishek", Id = 5, FieldExperience = 16},
            };
            return View(empList);
        }
    }
}