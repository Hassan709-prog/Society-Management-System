using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;


namespace SocietyManagementSystemControllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Adminlogin()
        {
            return View();
        }
        public ActionResult Lifestyle()
        {
            return View();
        }
        public ActionResult Contact()
            {
                return View();
            }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }

        [HttpPost]
            public ActionResult SubmitContactForm(string name, string email, string message)
            {
                try
                {
                 
                    SendEmail(name, email, message);

             
                    ViewBag.Message = "Your message has been sent successfully!";
                }
                catch (Exception ex)
                {
        
                    ViewBag.Message = "There was an error sending your message. Please try again.";
                    Console.WriteLine(ex.Message);
                }

                return View("Index"); 
            }

   
            private void SendEmail(string name, string email, string message)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("support@societymanagement.com"); 
                mail.From = new MailAddress(email);
                mail.Subject = "New Contact Form Submission";
                mail.Body = $"<p><b>Name:</b> {name}</p><p><b>Email:</b> {email}</p><p><b>Message:</b> {message}</p>";
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.yourmailserver.com", 
                    Port = 587, 
                    Credentials = new System.Net.NetworkCredential("your-email@example.com", "your-password"),
                    EnableSsl = true
                };

                smtp.Send(mail);
            }

    }
}