using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gxpt.Startup))]
namespace gxpt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
