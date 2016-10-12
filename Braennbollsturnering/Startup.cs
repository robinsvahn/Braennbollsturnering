using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Braennbollsturnering.Startup))]
namespace Braennbollsturnering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
