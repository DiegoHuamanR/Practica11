using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioPropuesto2.Startup))]
namespace EjercicioPropuesto2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
