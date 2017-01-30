using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BHI.MapApp.Startup))]
namespace BHI.MapApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
