using MVC.ModelView.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DeleteController : Controller
    {
        //
        // GET: /Delete/

        public ActionResult Index(int id)
        {
            eModelView empl = new eModelView();
            empl.Getdeleterecord(id);

            return RedirectToAction("index", "ManualDB");
        }

    }
}
