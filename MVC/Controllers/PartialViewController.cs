using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PartialViewController : Controller
    {
        //
        // GET: /PartialView/

        public ActionResult Index()
        {
            //dropdown list in partail View
            List<SelectListItem> lists = new List<SelectListItem>();
            lists.Add(new SelectListItem { Text = "Add", Value = "1" });
            lists.Add(new SelectListItem { Text = "Subtract", Value = "2" });
            ViewBag.lists = lists;

            
            
            //foreach loop in Partial View
            string[] opps = { "1", "2", "3" };
            ViewBag.listing = opps;


            

            return View();
        }

       

    }
}
