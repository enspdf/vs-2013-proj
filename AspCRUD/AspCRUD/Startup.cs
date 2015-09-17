using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspCRUD.Startup))]
namespace AspCRUD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
