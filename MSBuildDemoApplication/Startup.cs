using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSBuildDemoApplication.Startup))]
namespace MSBuildDemoApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
