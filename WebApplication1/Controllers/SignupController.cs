using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SignupController : Controller
    {
        public ActionResult Signuppage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signuppage(string name, string house_number, string email, string password)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(house_number) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.ErrorMessage = "All fields are required!";
                return View();
            }

            if (!IsValidEmail(email))
            {
                ViewBag.ErrorMessage = "Please enter a valid email address.";
                return View();
            }

            
            ViewBag.SuccessMessage = "You have successfully signed up!";

            return View();  
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
