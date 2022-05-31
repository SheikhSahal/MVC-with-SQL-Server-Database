using MVC.Models;
using MVC.ModelView.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ManualDBController : Controller
    {
        //
        // GET: /ManualDB/

        public ActionResult Index()
        {

            eModelView emplview = new eModelView();
            List<MDataEmp> emp = emplview.GEtdb();

            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(string Searchtext)
        {
            
            return View();
        }

    }
}
