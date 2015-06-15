using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubPublishApplication.Startup))]
namespace GitHubPublishApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
