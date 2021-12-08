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
    public class DrivingLicensesController : Controller
    {
        DrivingLicenseRepository drivingLicenseRepository = new DrivingLicenseRepository();
        

        // GET: Administrator/DrivingLicenses
        public ActionResult Index()
        {
            return View(drivingLicenseRepository.GetList());
        }

        // GET: Administrator/DrivingLicenses/Details/5
        public ActionResult Details(int id)
        {

            DrivingLicense drivingLicense = drivingLicenseRepository.GetById(id);
            if (drivingLicense == null)
            {
                return HttpNotFound();
            }
            return View(drivingLicense);
        }

        // GET: Administrator/DrivingLicenses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/DrivingLicenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,IssueDate,CardNo,LicenseClass,FatherName,MotherName,BirthDate,CreatedDate,ModifiedDate,DeletedDate,Status")] DrivingLicense drivingLicense)
        {
            if (ModelState.IsValid)
            {
                drivingLicenseRepository.Add(drivingLicense);
                return RedirectToAction("Index");
            }

            return View(drivingLicense);
        }

        // GET: Administrator/DrivingLicenses/Edit/5
        public ActionResult Edit(int id)
        {
           
            DrivingLicense drivingLicense = drivingLicenseRepository.GetById(id);
            if (drivingLicense == null)
            {
                return HttpNotFound();
            }
            return View(drivingLicense);
        }

        // POST: Administrator/DrivingLicenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,IssueDate,CardNo,LicenseClass,FatherName,MotherName,BirthDate,CreatedDate,ModifiedDate,DeletedDate,Status")] DrivingLicense drivingLicense)
        {
            if (ModelState.IsValid)
            {
                drivingLicenseRepository.Update(drivingLicense);
                return RedirectToAction("Index");
            }
            return View(drivingLicense);
        }

        // GET: Administrator/DrivingLicenses/Delete/5
        public ActionResult Delete(int id)
        {
            DrivingLicense drivingLicense = drivingLicenseRepository.GetById(id);
            if (drivingLicense == null)
            {
                return HttpNotFound();
            }
            return View(drivingLicense);
        }

        // POST: Administrator/DrivingLicenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DrivingLicense drivingLicense = drivingLicenseRepository.GetById(id);
            drivingLicenseRepository.RemoveForce(drivingLicense);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            
            base.Dispose(disposing);
        }
    }
}
