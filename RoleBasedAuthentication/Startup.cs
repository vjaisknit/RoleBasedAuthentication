using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBasedAuthentication.Startup))]
namespace RoleBasedAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
