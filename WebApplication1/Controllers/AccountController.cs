using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocietyManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult MemberLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MemberLogin(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid Username or Password!";
                return View();
            }
        }

        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid Username or Password!";
                return View();
            }
        }
    }
}