using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class cookiesController : Controller
    {
        //
        // GET: /cookies/

        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["Name"];

            if (cookie != null)
            {
                string name = Request.Cookies["Name"].Value;
                ViewBag.name = name;
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(cookies co)
        {
            if (ModelState.IsValid)
            {
                HttpCookie cookie = new HttpCookie("Name");
                cookie.Value = co.Name;

                HttpContext.Response.Cookies.Add(cookie);
            }
            return RedirectToAction("Index");
        }

    }
}
