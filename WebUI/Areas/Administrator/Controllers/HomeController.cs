using Project.BLL.DesignPatterns.GenericRepository.ConcreteRepo;
using Project.ENTİTİES.Models;
using Project.ENTİTİES.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebUI.Attiributes;

namespace WebUI.Areas.Administrator.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        // GET: Administrator/Home
        AppUserRepository appUserRepository = new AppUserRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ActFilter]
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


                        return RedirectToAction("Index");
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
                return View();
            }
            return View();
        }
    }
}