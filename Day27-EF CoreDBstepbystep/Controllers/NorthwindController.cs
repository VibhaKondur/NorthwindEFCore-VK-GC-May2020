using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day27_EF_CoreDBstepbystep.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day27_EF_CoreDBstepbystep.Controllers
{
    
    public class NorthwindController : Controller
    {

        private readonly NorthwindContext _context;

        public NorthwindController(NorthwindController context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //READ

            List<Customers> customers = _context.Customers.ToList();
            return View(customers);
        }

        public IActionResult CustomerForm()
        {
            return View();
        }

        public IActionResult EmployeeForm()
        {
            return View();
        }

        public IActionResult EmployeeIndex()
        {
            //READ

            List<Employees> employees = _context.Employees.ToList();
            return View(employees);

        }

        public IActionResult AddCustomer(Customers newCustomer)
        {
            if(ModelState.IsValid)
            {
                _context.Customers.Add(newCustomer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("CustomerForm");
        }

        public IActionResult AddEmployee(Employees newEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(newEmployee);
                _context.SaveChanges();
                return RedirectToAction("Employee Index");
            }
            return View("EmployeeForm");
        }
    }

    
}
