using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1_EntityFrameworkAsp.NetMVC.Startup))]
namespace Assignment1_EntityFrameworkAsp.NetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
