using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitMvcUI.Startup))]
namespace TestGitMvcUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
