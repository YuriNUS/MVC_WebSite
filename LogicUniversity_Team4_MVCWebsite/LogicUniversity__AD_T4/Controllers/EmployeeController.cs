using System;
using System.Web.Mvc;

namespace LogicUniversity__AD_T4.Controllers
{
    public class EmployeeController : Controller
    {
        
        public EmployeeController()
        {
            System.Web.HttpContext.Current.Session["role"] = "Employee";
        }
        // GET: Employee
        
        public ActionResult Home()
        {
            System.Web.HttpContext.Current.Session["role"] = "Employee";
            return View();
        }

        public ActionResult RequestItems()
        {
            return View();
        }
        public ActionResult RequestionList()
        {
            
            return View();
        }

    }
}