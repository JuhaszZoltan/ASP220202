using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP220202.Startup))]
namespace ASP220202
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
