using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopOnlineDemo.Startup))]
namespace ShopOnlineDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
