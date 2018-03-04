using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISS.Startup))]
namespace ISS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
