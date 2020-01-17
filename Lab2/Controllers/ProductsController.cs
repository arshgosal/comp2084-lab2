using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public String Details(String id)
        {
            string message = HttpUtility.HtmlEncode("You selected product: " + id);
            return message;
        }
    }
}