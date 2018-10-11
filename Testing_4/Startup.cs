using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testing_4.Startup))]
namespace Testing_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
