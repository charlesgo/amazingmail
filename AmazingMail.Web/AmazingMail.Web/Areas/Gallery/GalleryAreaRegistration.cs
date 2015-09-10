using System.Web.Mvc;

namespace AmazingMail.Web.Areas.Gallery
{
    public class GalleryAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Gallery";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.Routes.MapMvcAttributeRoutes();
            context.MapRoute(
               "Gallery_default",
               "Gallery/{action}/{id}",
               new { controller = "Gallery", action = "Index", id = UrlParameter.Optional,url="blahblah" }
           );
            
        }
    }
}