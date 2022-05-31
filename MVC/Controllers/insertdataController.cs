using MVC.Models;
using MVC.ModelView.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class insertdataController : Controller
    {
        //
        // GET: /insertdata/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MDataEmp md)
        {

            if (ModelState.IsValid)
            {
                eModelView empl = new eModelView();
                empl.AddNewEmployee(md);

                return RedirectToAction("index","ManualDB");
            }
            return View();
        }
    }
}
