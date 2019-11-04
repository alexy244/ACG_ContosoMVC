using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACGContosoMVC5.Startup))]
namespace ACGContosoMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
