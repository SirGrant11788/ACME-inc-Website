using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACMEINC.Startup))]
namespace ACMEINC
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
