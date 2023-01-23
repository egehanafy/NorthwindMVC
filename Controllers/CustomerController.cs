using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindMVC.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer {ID=1,CompanyName="Migros", ContactNumber="1234567890", Address = "İstanbul"},
            new Customer {ID=2,CompanyName="Carrefour", ContactNumber="1231231231", Address = "İzmir"},
            new Customer {ID=3,CompanyName="Teknosa", ContactNumber="3213213211", Address = "Eskişehir"},
            new Customer {ID=4,CompanyName="Vatan Bilgisayar", ContactNumber="3211233211", Address = "Ankara"}
        };
        public IActionResult Index()
        {
            ViewBag.Customers = customers;
            return View(customers);
        }

        public IActionResult AddCustomer()
        {
            ViewBag.Customers = customers;
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer model)
        {
            ViewBag.Employees = customers;
            customers.Add(model);
            return View(customers);
        }

        public ActionResult DeleteCustomer(int CustomerId)
        {
            ViewBag.Customers = customers;
            customers.Remove(customers.FirstOrDefault(x => x.ID == CustomerId));
            return View("Index");
        }
    }
}
