using Microsoft.AspNetCore.Mvc;
using NorthwindMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee {ID=1, FirstName="Ahmet",LastName="Mehmet", Speciality="Back-End"},
            new Employee {ID=2, FirstName="Ali",LastName="Veli", Speciality="Front-End"},
            new Employee {ID=3, FirstName="Ayşe",LastName="Fatma", Speciality="Project Manager"},
            new Employee {ID=4, FirstName="Ege",LastName="Mege", Speciality="Junior"},
        };
        public IActionResult Index()
        {
            ViewBag.Employees = employees;
            return View(employees);
        }
        public IActionResult AddEmployee()
        {
            ViewBag.Employees = employees;
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee model)
        {
            ViewBag.Employees = employees;
            employees.Add(model);
            return View(employees);
        }
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            ViewBag.Employees = employees;
            employees.Remove(employees.FirstOrDefault(x => x.ID == EmployeeId));
            return View("Index");
        }
    }
}
