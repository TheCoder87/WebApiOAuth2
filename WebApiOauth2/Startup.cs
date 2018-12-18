using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiOauth2.Startup))]
namespace WebApiOauth2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
