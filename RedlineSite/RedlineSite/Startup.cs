using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedlineSite.Startup))]
namespace RedlineSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
