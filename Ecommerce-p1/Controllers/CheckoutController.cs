using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_p1.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            if(!Request.IsAuthenticated)
            {
                Response.Redirect(Url.Action("Login", "Account"));
            }
            return View();
        }

        // GET: Checkout/Confirm
        public ActionResult Confirm()
        {
            return View();
        }
    }
}