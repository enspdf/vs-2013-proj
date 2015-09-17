using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_FACTURACION.Startup))]
namespace ASP_FACTURACION
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
