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
    public class EmployeeCardsController : Controller
    {
        EmployeeCardRepository employeeCardRepository = new EmployeeCardRepository();
        

        // GET: Administrator/EmployeeCards
        public ActionResult Index()
        {
            return View(employeeCardRepository.GetList());
        }

        // GET: Administrator/EmployeeCards/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCard employeeCard = employeeCardRepository.GetById(id);
            if (employeeCard == null)
            {
                return HttpNotFound();
            }
            return View(employeeCard);
        }

        // GET: Administrator/EmployeeCards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/EmployeeCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TCKNo,SerialNo,FirstName,LastName,FatherName,MotherName,BirthPlace,BirthDate,BloodGroup,IssueDate,IssuePlace,Religion,RegisteredProvince,RegisteredCountry,RegisteredVillage,MaritalStatus,VolumeNumber,FamilyNo,RowNo,EnrollmentNo,MotherLastName,CreatedDate,ModifiedDate,DeletedDate,Status")] EmployeeCard employeeCard)
        {
            if (ModelState.IsValid)
            {
                employeeCardRepository.Add(employeeCard);
               
                return RedirectToAction("Index");
            }

            return View(employeeCard);
        }

        // GET: Administrator/EmployeeCards/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCard employeeCard = employeeCardRepository.GetById(id);
            if (employeeCard == null)
            {
                return HttpNotFound();
            }
            return View(employeeCard);
        }

        // POST: Administrator/EmployeeCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TCKNo,SerialNo,FirstName,LastName,FatherName,MotherName,BirthPlace,BirthDate,BloodGroup,IssueDate,IssuePlace,Religion,RegisteredProvince,RegisteredCountry,RegisteredVillage,MaritalStatus,VolumeNumber,FamilyNo,RowNo,EnrollmentNo,MotherLastName,CreatedDate,ModifiedDate,DeletedDate,Status")] EmployeeCard employeeCard)
        {
            if (ModelState.IsValid)
            {
                employeeCardRepository.Update(employeeCard);
               
                return RedirectToAction("Index");
            }
            return View(employeeCard);
        }

        // GET: Administrator/EmployeeCards/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeCard employeeCard = employeeCardRepository.GetById(id);
            if (employeeCard == null)
            {
                return HttpNotFound();
            }
            return View(employeeCard);
        }

        // POST: Administrator/EmployeeCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeCard employeeCard = employeeCardRepository.GetById(id);
            employeeCardRepository.RemoveForce(employeeCard);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
           
            base.Dispose(disposing);
        }
    }
}
