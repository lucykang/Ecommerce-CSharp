using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce_p1.Models;

namespace Ecommerce_p1.Controllers
{
    /*
        File: OrderController.cs
        Authors: Yuji Fujiyama, John Allan, Lucy Kang
        Website: VendComp Electronics
        Description: controller that routes cart and order page.
    */
    public class OrderController : Controller
    {
        // GET: Order (displays shopping cart)
        public ActionResult Index()
        {
            return View();
        }

        // GET: Checkout
        public ActionResult Checkout()
        {
            return View();
        }
    }
}