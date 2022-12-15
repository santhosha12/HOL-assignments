using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL2.Controllers
{
    public class addtwoController : Controller
    {
        // GET: addtwo
        public ActionResult Index()
        {
            int a = 7, b = 17;
            int result = a+b;
            ViewBag.result=result;
            return View();
        }
    }
}