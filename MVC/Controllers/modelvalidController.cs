using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class modelvalidController : Controller
    {
        //
        // GET: /modelvalid/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ModelValid md)
        {
            if (ModelState.IsValid == true)
            {
                ViewBag.msge = "<script>alert('Changes are Saved') </script>";
            }

            return View();
        }

    }
}
