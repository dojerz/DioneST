using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DioneST.Startup))]
namespace DioneST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
