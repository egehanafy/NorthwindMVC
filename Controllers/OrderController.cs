using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NorthwindMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindMVC.Controllers
{
    public class OrderController : Controller
    {
        public static List<Order> orders = new List<Order>()
        {
            new Order {ID=1, Date=DateTime.Now,Address="Türkiye", ShippingFee=142},
            new Order {ID=2, Date=DateTime.Now,Address="Kanada", ShippingFee=432},
            new Order {ID=3, Date=DateTime.Now,Address="Almanya", ShippingFee=513},
            new Order {ID=4, Date=DateTime.Now,Address="Fransa", ShippingFee=1513},
        };
        public IActionResult Index()
        {
            ViewBag.Orders = orders;
            return View(orders);
        }

        public IActionResult AddOrder()
        {
            ViewBag.Orders = orders;
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(Order model)
        {
            ViewBag.Orders = orders;
            orders.Add(model);
            return View(orders);
        }

        public ActionResult DeleteOrder(int OrderId)
        {
            ViewBag.Orders = orders;
            orders.Remove(orders.FirstOrDefault(x => x.ID == OrderId));
            return View("Index");
        }
    }
}
