using Ecommerce_p1.Models;
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

        private StoreContext db = new StoreContext();

        // GET: Checkout
        [HttpGet]
        public ActionResult Index()
        {
            if(!Request.IsAuthenticated)
            {
                Response.Redirect(Url.Action("Login", "Account"));
            }
            return View();
        }

        // GET: Checkout/Confirm
        //[HttpPost]
        public ActionResult Confirm()
        {
            var cart = ShoppingCart.GetCart(HttpContext);

            var model = new CartOrderViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal(),

                Email = Request.Form["email"],
                Name = Request.Form["name"],
                Street = Request.Form["street"],
                Apt = Request.Form["st2"],
                City = Request.Form["city"],
                Province = Request.Form["state"],
                Postal = Request.Form["zip"],
                Phone = Request.Form["Phonecode"] + Request.Form["phone"],
                Country = Request.Form["country"],
                PaymentMethod = Request.Form["paymentType"]
            };

            return View(model);
        }

        // GET: Checkout/Purchase
        public ActionResult Purchase(CartOrderViewModel orderModel)
        {
            //Order order = new Order()
            //{
            //    Firstname = orderModel.Name,
            //    Lastname = orderModel.Name,
            //    Address = orderModel.Street,
            //    City = orderModel.City,
            //    Country = orderModel.Country,
            //    Email = orderModel.Email,
            //    Phone = orderModel.Phone,
            //    PostalCode = orderModel.Postal,
            //    Province = orderModel.Province,
            //    Total = orderModel.CartTotal,
            //    Username = User.Identity.Name,
            //    OrderDate = DateTime.Now
            //};


            //// save the order
            //db.Orders.Add(order);
            ////db.SaveChanges();

            //// process the order
            //var cart = ShoppingCart.GetCart(this.HttpContext);
            //cart.CreateOrder(order);

            //return RedirectToAction("Complete", new { id = order.OrderId });
            return RedirectToAction("Complete");
        }

        // GET: Checkout/Complete
        public ActionResult Complete(int? id)
        {
            if(id == null)
            {
                return View(224);
            }
            // Validate customer owns this order
            bool isValid = db.Orders.Any(
                o => o.OrderId == id &&
                o.Username == User.Identity.Name);

            if (isValid)
            {
                return View(id);
            }
            else
            {
                return View("Error");
            }
        }
    }
}