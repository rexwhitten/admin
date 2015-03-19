using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentACS.Admin.Startup))]
namespace CentACS.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
