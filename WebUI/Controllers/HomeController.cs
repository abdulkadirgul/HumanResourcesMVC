using Project.BLL.DesignPatterns.GenericRepository.ConcreteRepo;
using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebUI.Models.ViewModels;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        AppUserRepository appUserRepository = new AppUserRepository();
        EmployeeCardRepository employeeCardRepository = new EmployeeCardRepository();

        public PartialViewResult _NavbarPartial()
        {
            var cards = employeeCardRepository.GetList();
            return PartialView(cards);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Uygulama Açıklama Sayfası";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "İletişim Sayfası";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //[AcFilter]
        public ActionResult Login(LoginVM login)
        {

            if (ModelState.IsValid)
            {
                if (appUserRepository.Any(x => x.UserName == login.UserName))
                {

                    var result = appUserRepository.UserLogin(login.UserName, login.Password);



                    if (result)
                    {
                        AppUser user = appUserRepository.GetDefault(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();

                        Session["user"] = user;

                        //Cookie
                        FormsAuthentication.SetAuthCookie(user.UserName, true);


                        return RedirectToAction("Index", "Home", new { area = "Administrator" });
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }


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