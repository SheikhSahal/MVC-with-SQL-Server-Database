using System.Web.Mvc;

namespace MVC.Areas.GET_OR_POST
{
    public class GET_OR_POSTAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "GET_OR_POST";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "GET_OR_POST_default",
                "GET_OR_POST/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "MVC.Areas.GET_OR_POST.Controllers" }
            );
        }
    }
}
