using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spotr.Startup))]
namespace Spotr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
