using System.Web.Mvc;

namespace MVC.Areas.Accouts
{
    public class AccoutsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Accouts";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Accouts_default",
                "Accouts/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "MVC.Areas.Accouts.Controllers" }
            );
        }
    }
}
