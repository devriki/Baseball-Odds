using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseballOdds.Startup))]
namespace BaseballOdds
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
