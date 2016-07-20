using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quiron.LojaVirtual.Web.Startup))]
namespace Quiron.LojaVirtual.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
