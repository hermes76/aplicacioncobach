using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aplicacioncobach.backend.Startup))]
namespace aplicacioncobach.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
