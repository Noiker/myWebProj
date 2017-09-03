using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stepWebAppExample.Startup))]
namespace stepWebAppExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
