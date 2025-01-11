using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppAgenceVoyage.Startup))]
namespace AppAgenceVoyage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
