using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebsite.Data;
using EcommerceWebsite.Models;
using EcommerceWebsite.Utility;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }

        //GET Checkout Action Method
        public IActionResult Checkout()
        {
            return View();
        }

        //POST Checkout Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Order aOrder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.ProductId = product.Id;
                    aOrder.OrderDetails.Add(orderDetails);
                }
            }
            aOrder.OrderNo = GetOrderNo();
            _db.Order.Add(aOrder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());
            TempData["checkout"] = "Order has been successfully placed!";
            return RedirectToAction("Index", "Home", new { area = "Customer" });
        }

        public string GetOrderNo()
        {
            int rowCount = _db.Order.ToList().Count() + 1;
            return rowCount.ToString("000");
        }
    }
}
