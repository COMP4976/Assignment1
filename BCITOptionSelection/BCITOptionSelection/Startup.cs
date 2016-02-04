using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BCITOptionSelection.Startup))]
namespace BCITOptionSelection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
