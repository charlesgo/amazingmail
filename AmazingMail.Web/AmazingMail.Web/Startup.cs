using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmazingMail.Web.Startup))]
namespace AmazingMail.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
