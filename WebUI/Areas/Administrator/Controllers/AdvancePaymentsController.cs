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
    [Authorize(Roles = "Admin")]
    public class AdvancePaymentsController : Controller
    {
        
        AdvancePaymentRepository advancePaymentRepository = new AdvancePaymentRepository();
        AppDbContext db = new AppDbContext();

        // GET: Administrator/AdvancePayments
        public ActionResult Index()
        {
            
            return View(advancePaymentRepository.GetList());
        }

        // GET: Administrator/AdvancePayments/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvancePayment advancePayment = advancePaymentRepository.GetById(id);
            
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Amount,Description,IssueDate,ConfirmedDate,State,AdvancePaymentType,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] AdvancePayment advancePayment)
        {
            if (ModelState.IsValid)
            {
                advancePaymentRepository.Add(advancePayment);
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", advancePayment.EmployeeID);
            return View(advancePayment);
        }

        // GET: Administrator/AdvancePayments/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvancePayment advancePayment = advancePaymentRepository.GetById(id);
            if (advancePayment == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", advancePayment.EmployeeID);
            return View(advancePayment);
        }

        // POST: Administrator/AdvancePayments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Amount,Description,IssueDate,ConfirmedDate,State,AdvancePaymentType,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] AdvancePayment advancePayment)
        {
            if (ModelState.IsValid)
            {
                advancePaymentRepository.Update(advancePayment);
             
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", advancePayment.EmployeeID);
            return View(advancePayment);
        }

        // GET: Administrator/AdvancePayments/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdvancePayment advancePayment = advancePaymentRepository.GetById(id);
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
            AdvancePayment advancePayment = advancePaymentRepository.GetById(id);
            advancePaymentRepository.RemoveForce(advancePayment);
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
