using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(esuspomogiv2.Startup))]
namespace esuspomogiv2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
