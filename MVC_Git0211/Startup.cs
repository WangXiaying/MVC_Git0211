using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Git0211.Startup))]
namespace MVC_Git0211
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
