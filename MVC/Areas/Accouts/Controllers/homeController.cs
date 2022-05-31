using MVC.Areas.Accouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.Accouts.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /Accouts/home/

        public ActionResult Index()
        {

     //Viewdata
            ViewData["id"] = "1";
            ViewData["Name"] = "Sahal";
      
            //Fetch more data
            string[] lo = { "Ganja", "Munna", "Baqri" };
            ViewData["io"] = lo;
 
    
            //fetch data model to view
            optp fa = new optp { id = 1, Name = "Munna", Salary = 534 };
            ViewData["fat"] = fa;


            //Fetch more data model to view
            optp s1 = new optp { id = 3, Name = "Zaki", Salary = 35 };
            optp s2 = new optp { id = 4, Name = "Danish", Salary = 34 };
            optp s3 = new optp { id = 5, Name = "Arsalan", Salary = 36 };
            
            List<optp> lists = new List<optp>();
            lists .Add(s1);
            lists.Add(s2);
            lists.Add(s3);

            ViewData["fetch"] = lists;


            return View();
        }

    }
}
