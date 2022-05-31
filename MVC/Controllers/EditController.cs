using MVC.Models;
using MVC.ModelView.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class EditController : Controller
    {
        //
        // GET: /Edit/

        public ActionResult Index(int id)
        {
            eModelView empl = new eModelView();
            MDataEmp employee = empl.employeedetailbyid(id);

            return View(employee);
        }

        [HttpPost]
        public ActionResult Index(MDataEmp emp)
        {
            if (ModelState.IsValid)
            {
                eModelView empl = new eModelView();
                empl.updateemp(emp);
                return RedirectToAction("index", "ManualDB");
            }
            return View();
        }

    }
}
