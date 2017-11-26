using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab13.Startup))]
namespace Lab13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
