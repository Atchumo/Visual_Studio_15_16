using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP_B3_EPSI_2015.Startup))]
namespace TP_B3_EPSI_2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
