using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoomsApplication.Startup))]
namespace RoomsApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
