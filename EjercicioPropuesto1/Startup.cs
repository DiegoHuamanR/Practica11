using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjercicioPropuesto1.Startup))]
namespace EjercicioPropuesto1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
