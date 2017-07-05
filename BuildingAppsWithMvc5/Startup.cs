using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildingAppsWithMvc5.Startup))]
namespace BuildingAppsWithMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
