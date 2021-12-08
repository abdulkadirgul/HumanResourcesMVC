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
    public class ExpensesController : Controller
    {
        ExpenseRepository expenseRepository = new ExpenseRepository();
         AppDbContext db = new AppDbContext();

        // GET: Administrator/Expenses
        public ActionResult Index()
        {

            return View(expenseRepository.GetList()) ;
        }

        // GET: Administrator/Expenses/Details/5
        public ActionResult Details(int id)
        {

            Expense expense = expenseRepository.GetById(id);
            if (expense == null)
            {
                return HttpNotFound();
            }
            return View(expense);
        }

        // GET: Administrator/Expenses/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo");
            return View();
        }

        // POST: Administrator/Expenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,Amount,IsConfirmed,State,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] Expense expense)
        {
            if (ModelState.IsValid)
            {
                expenseRepository.Add(expense);
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", expense.EmployeeID);
            return View(expense);
        }

        // GET: Administrator/Expenses/Edit/5
        public ActionResult Edit(int id)
        {

            Expense expense = expenseRepository.GetById(id);
            if (expense == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", expense.EmployeeID);
            return View(expense);
        }

        // POST: Administrator/Expenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,Amount,IsConfirmed,State,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] Expense expense)
        {
            if (ModelState.IsValid)
            {
                expenseRepository.Update(expense);
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", expense.EmployeeID);
            return View(expense);
        }

        // GET: Administrator/Expenses/Delete/5
        public ActionResult Delete(int id)
        {
            
            Expense expense = expenseRepository.GetById(id);
            if (expense == null)
            {
                return HttpNotFound();
            }
            return View(expense);
        }

        // POST: Administrator/Expenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expense expense = expenseRepository.GetById(id);
            expenseRepository.RemoveForce(expense);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            
            base.Dispose(disposing);
        }
    }
}
