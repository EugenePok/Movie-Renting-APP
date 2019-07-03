using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieWeb.Startup))]
namespace MovieWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
