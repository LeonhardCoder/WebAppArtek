using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppArtek.Startup))]
namespace WebAppArtek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
