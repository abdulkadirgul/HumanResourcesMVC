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
    public class AllowRequestsController : Controller
    {
        AllowRequestRepository allowRequestRepository = new AllowRequestRepository();
        AppDbContext db = new AppDbContext();

        // GET: Administrator/AllowRequests
        public ActionResult Index()
        {
            var allowRequests = db.AllowRequests.Include(a => a.Employee);
            return View(allowRequests.ToList());
        }

        // GET: Administrator/AllowRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AllowRequest allowRequest = db.AllowRequests.Find(id);
            if (allowRequest == null)
            {
                return HttpNotFound();
            }
            return View(allowRequest);
        }

        // GET: Administrator/AllowRequests/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo");
            return View();
        }

        // POST: Administrator/AllowRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,IssueDate,ConfirmedDate,StartDate,EndDate,State,AllowType,TotalAllowTime,CompanyDescription,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] AllowRequest allowRequest)
        {
            if (ModelState.IsValid)
            {
                allowRequestRepository.Add(allowRequest);
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", allowRequest.EmployeeID);
            return View(allowRequest);
        }

        // GET: Administrator/AllowRequests/Edit/5
        public ActionResult Edit(int id)
        {
            
            AllowRequest allowRequest = allowRequestRepository.GetById(id);
            if (allowRequest == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", allowRequest.EmployeeID);
            return View(allowRequest);
        }

        // POST: Administrator/AllowRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,IssueDate,ConfirmedDate,StartDate,EndDate,State,AllowType,TotalAllowTime,CompanyDescription,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] AllowRequest allowRequest)
        {
            if (ModelState.IsValid)
            {
                allowRequestRepository.Update(allowRequest);
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", allowRequest.EmployeeID);
            return View(allowRequest);
        }

        // GET: Administrator/AllowRequests/Delete/5
        public ActionResult Delete(int id)
        {
            AllowRequest allowRequest = allowRequestRepository.GetById(id);
            if (allowRequest == null)
            {
                return HttpNotFound();
            }
            return View(allowRequest);
        }

        // POST: Administrator/AllowRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AllowRequest allowRequest = allowRequestRepository.GetById(id);
            allowRequestRepository.RemoveForce(allowRequest);
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
