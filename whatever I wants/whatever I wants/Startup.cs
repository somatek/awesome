using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(whatever_I_wants.Startup))]
namespace whatever_I_wants
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
