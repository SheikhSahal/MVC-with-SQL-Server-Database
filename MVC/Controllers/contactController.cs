using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class contactController : Controller
    {
        //
        // GET: /contact/

        public ActionResult contact()
        {
            // ViewDate
            ViewData["id"] = "1";
            ViewData["user"] = "Smith";

            //ViewData Transfer data Model to view
            string[] link = { "smith", "james", "lewis" };
            ViewData["fetch"] = link;


            //ViewData Transfer  Model to view
            Schol school = new Schol() { id=1 , Name = "zubair", Salary= 500};
            Schol school1 = new Schol { id = 1, Name = "faiza", Salary = 200 };
            Schol school2 = new Schol { id = 3, Name = "farwa", Salary = 233 };
            Schol school3 = new Schol { id = 5, Name = "shanza", Salary = 342 };

            List<Schol> lists = new List<Schol>();
            lists.Add(school);
            lists.Add(school1);
            lists.Add(school2);
            lists.Add(school3);

            ViewData["scol"] = lists;

            return View();
        }


   

    }
}
