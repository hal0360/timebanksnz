using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimebanksNZ.Startup))]
namespace TimebanksNZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
