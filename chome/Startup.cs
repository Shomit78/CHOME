using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chome.Startup))]
namespace chome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
