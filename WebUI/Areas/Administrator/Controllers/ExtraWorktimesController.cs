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
    public class ExtraWorktimesController : Controller
    {
        ExtraWorktimeRepository extraWorktimeRepository = new ExtraWorktimeRepository();
        AppDbContext db = new AppDbContext();

        // GET: Administrator/ExtraWorktimes
        public ActionResult Index()
        {

            return View(extraWorktimeRepository.GetList());
        }

        // GET: Administrator/ExtraWorktimes/Details/5
        public ActionResult Details(int id)
        {

            ExtraWorktime extraWorktime = extraWorktimeRepository.GetById(id);
            if (extraWorktime == null)
            {
                return HttpNotFound();
            }
            return View(extraWorktime);
        }

        // GET: Administrator/ExtraWorktimes/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo");
            return View();
        }

        // POST: Administrator/ExtraWorktimes/Create


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,StartDate,EndTime,ConfirmedTime,IsConfirmed,State,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] ExtraWorktime extraWorktime)
        {
            if (ModelState.IsValid)
            {
                extraWorktimeRepository.Add(extraWorktime);
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", extraWorktime.EmployeeID);
            return View(extraWorktime);
        }

        // GET: Administrator/ExtraWorktimes/Edit/5
        public ActionResult Edit(int id)
        {

            ExtraWorktime extraWorktime = extraWorktimeRepository.GetById(id);
            if (extraWorktime == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", extraWorktime.EmployeeID);
            return View(extraWorktime);
        }

        // POST: Administrator/ExtraWorktimes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,StartDate,EndTime,ConfirmedTime,IsConfirmed,State,EmployeeID,CreatedDate,ModifiedDate,DeletedDate,Status")] ExtraWorktime extraWorktime)
        {
            if (ModelState.IsValid)
            {
                extraWorktimeRepository.Update(extraWorktime);
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Employees, "ID", "TCKNo", extraWorktime.EmployeeID);
            return View(extraWorktime);
        }

        // GET: Administrator/ExtraWorktimes/Delete/5
        public ActionResult Delete(int id)
        {

            ExtraWorktime extraWorktime = extraWorktimeRepository.GetById(id);
            if (extraWorktime == null)
            {
                return HttpNotFound();
            }
            return View(extraWorktime);
        }

        // POST: Administrator/ExtraWorktimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ExtraWorktime extraWorktime = extraWorktimeRepository.GetById(id);
            extraWorktimeRepository.RemoveForce(extraWorktime);
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
