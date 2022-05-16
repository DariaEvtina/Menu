using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Menu.Startup))]
namespace Menu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
