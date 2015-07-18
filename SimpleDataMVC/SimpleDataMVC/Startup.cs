using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleDataMVC.Startup))]
namespace SimpleDataMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
