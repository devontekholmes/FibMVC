using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibMVC.Controllers
{
    public class FibHomeController : Controller
    {
        // GET: FibHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FibTest()
        {

            return View();
        }

        public ViewResult Fibby()
        {
            return View();
        }

        public PartialViewResult TellMeAFib(int limit)
        {
            return PartialView();
        }

        
    }
}