using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class modelvalidwithclassController : Controller
    {
        //
        // GET: /modelvalidwithclass/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(form fo)
        {

            if (ModelState.IsValid == true)
            {
                ViewBag.msge = "<script>alert('Changes is Saved')</script>";
            }
            return View();
        }
    }
}
