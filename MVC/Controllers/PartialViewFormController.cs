using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PartialViewFormController : Controller
    {
        //
        // GET: /PartialViewForm/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PVform pv)
        {
            var a = "";
            string b = pv.Name;
            string c = pv.Email;
            int d = pv.Age;
            int e = pv.Phone;

            a = b+" "+ " "+c+" "+d+" "+"0"+e;
            ViewBag.shw = a;

            return View();
        }
    }
}
