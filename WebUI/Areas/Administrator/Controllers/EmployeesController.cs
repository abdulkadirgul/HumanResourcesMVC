using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.BLL.DesignPatterns.GenericRepository.ConcreteRepo;
using Project.DAL.Context;
using Project.ENTİTİES.Models;


namespace WebUI.Areas.Administrator.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        // GET: Administrator/Employees
        public ActionResult Index()
        {
            return View(employeeRepository.GetList());
        }

        // GET: Administrator/Employees/Details/5
        public ActionResult Details(int id)
        {
           
            Employee employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Administrator/Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TCKNo,FirstName,LastName,SGKNo,İseBaslama,CheckInTime,CheckInOutTime,AllowRequestID,AdvancePaymentID,ExpenseID,ExtraWorktimeID,CreatedDate,ModifiedDate,DeletedDate,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Add(employee);
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Administrator/Employees/Edit/5
        public ActionResult Edit(int id)
        {
            
            Employee employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Administrator/Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TCKNo,FirstName,LastName,SGKNo,İseBaslama,CheckInTime,CheckInOutTime,AllowRequestID,AdvancePaymentID,ExpenseID,ExtraWorktimeID,CreatedDate,ModifiedDate,DeletedDate,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Update(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Administrator/Employees/Delete/5
        public ActionResult Delete(int id)
        {
            
            Employee employee = employeeRepository.GetById(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Administrator/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = employeeRepository.GetById(id);
            employeeRepository.RemoveForce(employee);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            
            base.Dispose(disposing);
        }
    }
}
