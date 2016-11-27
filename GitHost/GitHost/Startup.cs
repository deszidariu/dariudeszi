using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHost.Startup))]
namespace GitHost
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
