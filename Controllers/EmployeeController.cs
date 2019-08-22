using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDbContext _db;
        public EmployeeController()
        {
            _db = new EmployeeDbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var employees = _db.Employees.ToList();
            return View(employees);
        }

       

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(model);
                _db.SaveChanges();
            }

            return View();
        }

    }
}