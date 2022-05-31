using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class sendemailController : Controller
    {
        //
        // GET: /sendemail/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(sendmail sm)
        {

            if (ModelState.IsValid)
            {
                WebMail.Send(sm.send,
                             sm.Name,
                             sm.Message,
                             null,
                             null,
                             null,
                             true,
                             null,
                             null,
                             null,
                             null,
                             null,
                             null);
            }

            return View();
        }

    }
}
