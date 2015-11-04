using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHome.Startup))]
namespace CHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
