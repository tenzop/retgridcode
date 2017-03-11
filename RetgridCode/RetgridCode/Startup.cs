using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetgridCode.Startup))]
namespace RetgridCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
