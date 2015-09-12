using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalAzureWebSite.Startup))]
namespace PersonalAzureWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
