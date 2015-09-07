using System.Web.Mvc;

namespace AmazingMail.Web.Areas.Products
{
    public class ProductsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Products";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Products_default",
                "Products/{action}/{id}",
                new { controller = "Products",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}