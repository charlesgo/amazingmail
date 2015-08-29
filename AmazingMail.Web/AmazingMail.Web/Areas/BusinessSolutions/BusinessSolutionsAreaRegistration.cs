using System.Web.Mvc;

namespace AmazingMail.Web.Areas.BusinessSolutions
{
    public class BusinessSolutionsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BusinessSolutions";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BusinessSolutions_default",
                "BusinessSolutions/{action}/{id}",
                new { controller = "BusinessSolutions", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}