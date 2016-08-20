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
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection values)
        {
            var order = new Order();
            TryUpdateModel(order);

            try
            {
                order.Username = User.Identity.Name;
                order.OrderDate = DateTime.Now;

                //Save Order
                db.Orders.Add(order);
                db.SaveChanges();

                //Process the order
                var cart = ShoppingCart.GetCart(this.HttpContext);
                cart.CreateOrder(order);

                return RedirectToAction("Confirm",  new { id = order.OrderId });
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        // POST: Checkout/Confirm
        public ActionResult Confirm(int id)
        {
            var order = (from orderList in db.Orders
                         where orderList.OrderId == id
                         select orderList).FirstOrDefault();

            var cart = ShoppingCart.GetCart(this.HttpContext);

            var model = new CartOrderViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal(),

                Email = order.Email,
                Name = order.Firstname,
                Street = order.Address,
                City = order.City,
                Province = order.Province,
                Postal = order.PostalCode,
                Phone = order.Phone,
                Country = order.Country,
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