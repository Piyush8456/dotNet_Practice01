using Filters01.filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters01.Controllers
{
    public class HomeController : Controller
    {
        //[HandleError]

        public ActionResult Index()
        {
            //throw new Exception();
            return View();
        }



        public ActionResult ErrorPage()
        {
            return View();

        }


        [OutputCache(Duration =10)]
        public ActionResult About()
        {
              ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }

        [ManualFilter]
        public ActionResult Contact()
        {
            return View();
        }
    }
}