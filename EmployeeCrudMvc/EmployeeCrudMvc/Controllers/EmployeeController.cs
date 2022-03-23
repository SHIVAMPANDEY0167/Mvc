using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using EmployeeCrudMvc.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeCrudMvc.Service;

namespace EmployeeCrudMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            var employees = _employeeService.GetEmployeeViewModels();
                return View(employees);
            
        }

        public ActionResult Details(int id)
        {

            var employee = _employeeService.GetEmployeeViewModels(id);
            return View(employee);
            
        }

        //
        // GET: /Associates/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Associates/Create
        [HttpPost]
        public ActionResult Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /Associates/Edit/5
        public ActionResult Edit(int id )
        {
            var employee = _employeeService.GetEmployeeViewModels(id); 
                return View(employee);  
        }

        //
        // POST: /Associates/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EmployeeViewModel employeeees)
        {
            _employeeService.Edit(id, employeeees);
            return RedirectToAction("Index");
        }

        //
        // GET: /Associates/Delete/5
        public ActionResult Delete(int id)
        {
              var employee = _employeeService.GetEmployeeViewModels(id);
                return View(employee);
            
        }

        //
        // POST: /Associates/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, EmployeeViewModel employee)
        {
            _employeeService.Delete(id, employee);
            return RedirectToAction("Index");
        }
        public ActionResult Department()
        {
            return View();
        }
    }
}