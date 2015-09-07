using System.Web.Mvc;

namespace AmazingMail.Web.Areas.About
{
    public class AboutAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "About";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "About_default",
                "About/{action}/{id}",
                new { controller = "About", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}