using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplicationNormal.Startup))]
namespace WebApplicationNormal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
