using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection Bundles)
        { 
        //Scripts
            Bundles.Add(new ScriptBundle("~/bundles/js").Include
                ("~/bootstrap/js/bootstrap.js",
                "~/bootstrap/js/jquery-3.2.1.js"));

             
            //CSS
            Bundles.Add(new StyleBundle("~/bundles/css").Include
                ("~/Bootstrap/css/bootstrap.css",
                "~/Bootstrap/css/Stylesheet1.css"));


            BundleTable.EnableOptimizations = true;
        }
    }
}