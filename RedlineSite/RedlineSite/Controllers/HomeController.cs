using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace RedlineSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var to store the main content of the home page
            var mainText = System.IO.File.ReadAllText(Server.MapPath(@"~/App_Data/HomeData.txt"));
            //var to store opening times
            var times = System.IO.File.ReadAllText(Server.MapPath(@"~/App_Data/OpenTimes.txt"));
            //var to store the email and phone number
            var emailAndPhone = System.IO.File.ReadAllText(Server.MapPath(@"~/App_Data/EmailAndPhone.txt"));
            //var to store the address
            var address = System.IO.File.ReadAllText(Server.MapPath(@"~/App_Data/Address.txt"));

            //Sending the data to the home page
            ViewBag.Title = "Redline Components";
            ViewBag.Content = mainText;
            ViewBag.Times = times;
            ViewBag.EmailAndPhone = emailAndPhone;
            ViewBag.Address = address;


            return View();
        }
    }
}