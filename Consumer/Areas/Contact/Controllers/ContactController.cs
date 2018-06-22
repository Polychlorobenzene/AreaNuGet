using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Provider.Areas.Contact.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact/Contact
        public ActionResult Index()
        {
            ViewBag.Message = "Your contact page from the package.";
            return View();
        }
    }
}