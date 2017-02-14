using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeliciaMcTernanPortfolio.Startup))]
namespace FeliciaMcTernanPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
