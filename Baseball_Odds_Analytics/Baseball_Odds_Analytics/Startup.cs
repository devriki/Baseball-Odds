using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Baseball_Odds_Analytics.Startup))]
namespace Baseball_Odds_Analytics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
