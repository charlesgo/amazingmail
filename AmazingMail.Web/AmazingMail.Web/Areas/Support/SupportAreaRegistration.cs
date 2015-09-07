using System.Web.Mvc;

namespace AmazingMail.Web.Areas.Support
{
    public class SupportAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Support";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Support_default",
                "Support/{action}/{id}",
                new { controller="Support",action = "Index", id = UrlParameter.Optional }
            );  
        }
    }
}