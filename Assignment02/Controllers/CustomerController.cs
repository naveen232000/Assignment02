using Assignment02.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Assignment02.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<string> list = new List<string>() {
        "Naveen","Jon","Sam","Leo","Fiz"
        };
            ViewBag.CustList = list;
            return View();
        }
        public ActionResult RedirectDemo() {

            TempData["Msg"] = "welcome to Customer MVC";
            return RedirectToAction("DisplayMessage");
        }
        public ActionResult DisplayMessage() {

            string message = TempData["Msg"] as string;
            ViewBag.Message = message;
            return View();
        }
    }
}