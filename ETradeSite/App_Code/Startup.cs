using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETradeSite.Startup))]
namespace ETradeSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
