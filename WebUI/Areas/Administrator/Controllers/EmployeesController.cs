using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project.DAL.Context;
using Project.ENTİTİES.Models;

namespace WebUI.Areas.Administrator.Controllers
{
    public class EmployeesController : Controller
    {
        Project.DAL.Context.AppContext db = new Project.DAL.Context.AppContext();

        // GET: Administrator/Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.DrivingLicense).Include(e => e.EmployeeCard);
            return View(employees.ToList());
        }

        // GET: Administrator/Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Administrator/Employees/Create
        public ActionResult Create()
        {
            ViewBag.DrivingLicenseID = new SelectList(db.DrivingLicenses, "ID", "FirstName");
            ViewBag.EmployeeCardID = new SelectList(db.EmployeeCards, "ID", "TCKNo");
            return View();
        }

        // POST: Administrator/Employees/Create
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TCKNo,FirstName,LastName,SGKNo,İseBaslama,CheckInTime,CheckInOutTime,EmployeeCardID,DrivingLicenseID,AllowRequestID,AdvancePaymentID,ExpenseID,ExtraWorktimeID,CreatedDate,ModifiedDate,DeletedDate,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DrivingLicenseID = new SelectList(db.DrivingLicenses, "ID", "FirstName", employee.DrivingLicenseID);
            ViewBag.EmployeeCardID = new SelectList(db.EmployeeCards, "ID", "TCKNo", employee.EmployeeCardID);
            return View(employee);
        }

        // GET: Administrator/Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DrivingLicenseID = new SelectList(db.DrivingLicenses, "ID", "FirstName", employee.DrivingLicenseID);
            ViewBag.EmployeeCardID = new SelectList(db.EmployeeCards, "ID", "TCKNo", employee.EmployeeCardID);
            return View(employee);
        }

        // POST: Administrator/Employees/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TCKNo,FirstName,LastName,SGKNo,İseBaslama,CheckInTime,CheckInOutTime,EmployeeCardID,DrivingLicenseID,AllowRequestID,AdvancePaymentID,ExpenseID,ExtraWorktimeID,CreatedDate,ModifiedDate,DeletedDate,Status")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DrivingLicenseID = new SelectList(db.DrivingLicenses, "ID", "FirstName", employee.DrivingLicenseID);
            ViewBag.EmployeeCardID = new SelectList(db.EmployeeCards, "ID", "TCKNo", employee.EmployeeCardID);
            return View(employee);
        }

        // GET: Administrator/Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
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
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
