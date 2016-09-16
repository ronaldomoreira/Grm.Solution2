using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grm.Teste02.Startup))]
namespace Grm.Teste02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
