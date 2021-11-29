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
using Project.DAL.Context;

namespace WebUI.Areas.Administrator.Controllers
{
    public class AdvancePaymentsController : Controller
    {
        Project.DAL.Context.AppContext db = new Project.DAL.Context.AppContext();

        // GET: Administrator/AdvancePayments
        public ActionResult Index()
        {
            var advancePayments = db.AdvancePayments.Include(a => a.Employee);
            return View(advancePayments.ToList());
        }

        // GET: Administrator/AdvancePayments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvancePayment advancePayment = db.AdvancePayments.Find(id);
            if (advancePayment == null)
            {
                return HttpNotFound();
            }
            return View(advancePayment);
        }

        // GET: Administrator/AdvancePayments/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo");
            return View();
        }

        // POST: Administrator/AdvancePayments/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Amount,Description,IssueDate,ConfirmedDate,State,AdvancePaymentType,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] AdvancePayment advancePayment)
        {
            if (ModelState.IsValid)
            {
                db.AdvancePayments.Add(advancePayment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", advancePayment.EmployeeID);
            return View(advancePayment);
        }

        // GET: Administrator/AdvancePayments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvancePayment advancePayment = db.AdvancePayments.Find(id);
            if (advancePayment == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", advancePayment.EmployeeID);
            return View(advancePayment);
        }

        // POST: Administrator/AdvancePayments/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Amount,Description,IssueDate,ConfirmedDate,State,AdvancePaymentType,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] AdvancePayment advancePayment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advancePayment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", advancePayment.EmployeeID);
            return View(advancePayment);
        }

        // GET: Administrator/AdvancePayments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvancePayment advancePayment = db.AdvancePayments.Find(id);
            if (advancePayment == null)
            {
                return HttpNotFound();
            }
            return View(advancePayment);
        }

        // POST: Administrator/AdvancePayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdvancePayment advancePayment = db.AdvancePayments.Find(id);
            db.AdvancePayments.Remove(advancePayment);
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
