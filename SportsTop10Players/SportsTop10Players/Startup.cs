using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsTop10Players.Startup))]
namespace SportsTop10Players
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
