using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class aboutController : Controller
    {
        //
        // GET: /about/

        public ActionResult about()
        {

            links s1 = new links { link = "https://www.google.com.pk/", names = "Google" };
            links s2 = new links { link = "https://duckduckgo.com/", names = "Duck" };

            List<links> lists = new List<links>();
            lists.Add(s1);
            lists.Add(s2);



            // Fetch more data View to View with the help of Tempdata
            Schol sa1 = new Schol { id = 3, Name = "Ganja", Salary = 353 };
            Schol sa2 = new Schol { id = 4, Name = "Munna", Salary = 356 };

            List<Schol> listss = new List<Schol>();
            listss.Add(sa1);
            listss.Add(sa2);

            TempData["trans"] = listss;
            TempData.Keep();

            return View(lists);
        }


        public ActionResult index2()
        {

            links link = new links() { link = "https://www.templatemonster.com/", names = "Template Monster" };
            links link2 = new links() { link = "https://www.daraz.pk/", names = "Daraz" };

            List<links> URL = new List<links>();
            URL.Add(link);
            URL.Add(link2);
            
            return View(URL);
        }


    }
}
