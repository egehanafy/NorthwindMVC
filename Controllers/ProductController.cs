using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindMVC.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>()
        {
            new Product {ID=1, ProductName="Burçak",CategoryName="Gıda", Supplier="Eti", UnitPrice=15, UnitsInstock=2000},
            new Product {ID=2, ProductName="Kazak",CategoryName="Giyim", Supplier="Koton", UnitPrice=400, UnitsInstock=500},
            new Product {ID=3, ProductName="Iphone",CategoryName="Teknoloji", Supplier="Apple", UnitPrice=40000, UnitsInstock=300},
            new Product {ID=4, ProductName="VR90X",CategoryName="Teknoloji", Supplier="MSI", UnitPrice=70000, UnitsInstock=15},
        };

        public IActionResult Index()
        {
            ViewBag.Products = products;
            return View(products);
        }
        public IActionResult AddProduct()
        {
            ViewBag.Products = products;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            ViewBag.Products = products;
            products.Add(model);
            return View(products);
        }

        public ActionResult DeleteProduct(int ProductId)
        {
            ViewBag.Products = products;
            products.Remove(products.FirstOrDefault(x => x.ID == ProductId));
            return View("Index");
        }

    }
}
