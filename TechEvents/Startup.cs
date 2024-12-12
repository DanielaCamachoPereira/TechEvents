using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechEvents.Startup))]
namespace TechEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
