using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce_p1.Models;

namespace Ecommerce_p1.Controllers
{
    /*
        File: ProductsController.cs
        Authors: Yuji Fujiyama, John Allan, Lucy Kang
        Website: VendComp Electronics
        Description: controller that routes products index, browse and details page.
    */
    public class ProductsController : Controller
    {
        // GET: Products
        // This page will show all the products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Browse?Type=Desktop
        public ActionResult Browse(string type)
        {
            
            return View();
        }

        // GET: Products/Details?id=1
        public ActionResult Details(int id = 1)
        {
            
            return View();
        }

    }
}