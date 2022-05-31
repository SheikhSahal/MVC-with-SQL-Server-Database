using MVC.Models;
using MVC.ModelView.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DetailsController : Controller
    {
        //
        // GET: /Details/

        public ActionResult Index(int id)
        {
            eModelView empl = new eModelView();
            MDataEmp employee = empl.employeedetailbyid(id);

            return View(employee);
        }

    }
}
