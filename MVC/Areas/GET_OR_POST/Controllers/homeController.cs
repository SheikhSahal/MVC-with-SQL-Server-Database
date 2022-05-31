using MVC.Areas.GET_OR_POST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.GET_OR_POST.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /GET_OR_POST/home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string first , string second , string email , string DOB)
        {
            if (first.Length == 0)
            {
                ModelState.AddModelError("first", "First No is required");
            }

            if (second.Length == 0)
            {
                ModelState.AddModelError("second", "Second No is required");
            }

            if (email.Length == 0)
            {
                ModelState.AddModelError("Email", "Email is required");
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (!regex.IsMatch(email))
                {
                    ModelState.AddModelError("email", "Email is not correct");
                    
                }
            }

            if (DOB.Length == 0)
            {
                ModelState.AddModelError("DOB", "Date is required");
            }
            else
            {
                DateTime temdate;
                bool Datecorrect = DateTime.TryParse(DOB, out temdate);

                if (!Datecorrect)
                {
                    ModelState.AddModelError("DOB", "date is not correct format DD/MON/YY");
                }
            }

            if (ModelState.IsValid == true)
            {
                ViewBag.errormsge = "<script>alert('Change are Saved');</script>";
            }
            string a = first + " " + second;
            
            ViewBag.b = a;

            return View();
        
        }

        public ActionResult DropDown()
        {
            List<SelectListItem> items = Getlist();

            ViewBag.operations = items;
        return View();
        }

        private static List<SelectListItem> Getlist()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "Add", Value = "1" });
            items.Add(new SelectListItem { Text = "Subtract", Value = "2" });
            items.Add(new SelectListItem { Text = "Multiple", Value = "3" });
            items.Add(new SelectListItem { Text = "Divide", Value = "4" });
            return items;
        }
        
        [HttpPost]
        public ActionResult DropDown(double firstnumber , double lastnumber , int operation)
        {
            
            
            
            double t = 0;
            switch (operation)
            {
                case 1:
                    t = firstnumber + lastnumber;
                    break;
                case 2:
                    t = firstnumber - lastnumber;
                    break;
                case 3:
                    t = firstnumber * lastnumber;
                    break;
                case 4:
                    t = firstnumber / lastnumber;
                    break;
            }
            

            ViewBag.result = t;

            List<SelectListItem> items = Getlist();

            ViewBag.operations = items;
            return View();
        }
        



        //Drop Down Strongly type [HttpGet]
        public ActionResult sdropdown()
        {

            return View();
        }

        //Drop Down Strongly type [HttpPost]
        [HttpPost]
        public ActionResult sdropdown(Maths math)
        {
            double r = math.fno;
            double l = math.lno;

            double result = r + l;

            ViewBag.re = result;

            return View();
        }


    }
}
