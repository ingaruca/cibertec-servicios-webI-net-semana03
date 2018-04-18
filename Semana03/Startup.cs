using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Semana03.Startup))]
namespace Semana03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
