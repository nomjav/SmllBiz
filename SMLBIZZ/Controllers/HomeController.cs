using SMLBIZZ.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace SMLBIZZ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LeadManagement()
        {
            return View();
        }

        public ActionResult EmailCampaigns()
        {
            return View();
        }

        public ActionResult TextChat()
        {
            return View();
        }

        public ActionResult VisualPipelines()
        {
            return View();
        }

        public ActionResult ChatBot()
        {
            return View();
        }

        public ActionResult DocumentFiling()
        {
            return View();
        }

        public ActionResult Pricing()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactUsModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SmtpSection section = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                    string from = section.From;
                    string host = section.Network.Host;
                    int port = section.Network.Port;
                    bool enableSsl = section.Network.EnableSsl;
                    string user = section.Network.UserName;
                    string password = section.Network.Password;
                    string body = "";
                    body += "<p>Contact Us Details of Visitor</p>";
                    body += "<br /><p>Name : "+vm.name+" </p>";
                    body += "<p>Email : " + vm.email + " </p>";
                    body += "<p>Subject : " + vm.subject + " </p>";
                    body += "<p>Message : " + vm.message + " </p>";

                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(from);//Email which you are getting 
                                                     //from contact us page 
                                                     // Email Info
                                                     //msz.To.Add("info@smllbiz.com");//Where mail will be sent 
                    msz.To.Add("info@smllbiz.com");
                    msz.Subject = vm.subject;
                    msz.IsBodyHtml = true;
                    msz.Body = body;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = host;
                    smtp.Port = port;
                    smtp.Credentials = new System.Net.NetworkCredential(user, password);
                    smtp.EnableSsl = true;
                    smtp.Send(msz);

                    // Email Visitor
                    MailMessage msz1 = new MailMessage();
                    msz1.From = new MailAddress(from);
                    msz1.To.Add(vm.email);//Where mail will be sent 
                    msz1.Subject = "Thanks for Contacting SMLLBIZ.Com";
                    msz1.Body = "We will respond to your request shortly!";
                    smtp.Host = host;
                    smtp.Port = port;
                    smtp.Credentials = new System.Net.NetworkCredential(user, password);
                    smtp.EnableSsl = true;
                    smtp.Send(msz1);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult RequestDemo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult RequestDemo(ReuestModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    SmtpSection section = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                    string from = section.From;
                    string host = section.Network.Host;
                    int port = section.Network.Port;
                    bool enableSsl = section.Network.EnableSsl;
                    string user = section.Network.UserName;
                    string password = section.Network.Password;
                    string body = "";
                    body += "<p>Request Demo Details from the Visitor</p>";
                    body += "<br /><p>Name : " + vm.name + " </p>";
                    body += "<p>Email : " + vm.email + " </p>";
                    body += "<p>Schedule Date : " + vm.scheduleDate + " </p>";
                    body += "<p>Message : " + vm.message + " </p>";
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(from);//Email which you are getting 
                                                     //from contact us page 
                                                     // Email Info
                                                     //msz.To.Add("info@smllbiz.com");//Where mail will be sent 
                    msz.To.Add("info@smllbiz.com");
                    msz.Subject = "Request Demo";
                    msz.IsBodyHtml = true;
                    msz.Body = body;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = host;
                    smtp.Port = port;
                    smtp.Credentials = new System.Net.NetworkCredential(user, password);
                    smtp.EnableSsl = true;
                    smtp.Send(msz);

                    // Email Visitor
                    MailMessage msz1 = new MailMessage();
                    msz1.From = new MailAddress(from);
                    msz1.To.Add(vm.email);//Where mail will be sent 
                    msz1.Subject = "Thanks for Contacting SMLLBIZ.Com";
                    msz1.Body = "We will respond to your request shortly!";
                    smtp.Host = host;
                    smtp.Port = port;
                    smtp.Credentials = new System.Net.NetworkCredential(user, password);
                    smtp.EnableSsl = true;
                    smtp.Send(msz1);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }
            return View();
        }

    }
}
