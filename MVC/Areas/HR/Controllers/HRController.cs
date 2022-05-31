using MVC.Areas.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.HR.Controllers
{
    public class HRController : Controller
    {
        //
        // GET: /HR/HR/

        public ActionResult HR()
        {
            // Inline expersion 
            ViewBag.name = "Zubair";
            ViewBag.sal = "25000";


            // for each loop
            string[] Stud = {"Smith","kalye" ,"Google"};
            ViewBag.student = Stud;

            room s = new room() { ID = 1, Name = "Irfanbhai", Salary = 11111111 };
            ViewBag.data=s;



            // fetch more data model to view
            room e = new room() { ID = 2, Name = "farooqbhai", Salary = 3423423 };
            room t = new room() { ID = 3, Name = "junaidbhai", Salary = 3344 };
            
            List<room> list = new List<room>();
            list.Add(e);
            list.Add(t);

            ViewBag.moredata = list;

            return View();
        }


        public object List { get; set; }
    }
}
