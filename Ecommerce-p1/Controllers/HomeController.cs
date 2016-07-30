using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_p1.Controllers
{
    /*
        File: HomeController.cs
        Authors: Yuji Fujiyama, John Allan, Lucy Kang
        Website: VendComp Electronics
        Description: controller that routes landing, about and contact page.
    */
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}