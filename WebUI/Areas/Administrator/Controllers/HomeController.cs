using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Administrator/Home
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogOut(AppUser user)
        {
            if (user != null)
            {
                Session.Remove("user");
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}