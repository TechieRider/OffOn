using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThisProject.Startup))]
namespace ThisProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
