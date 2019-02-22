using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedlineSite.Models;
using System.Data.SqlClient;

namespace RedlineSite.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            
            return View();
        }
    }
}