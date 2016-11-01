using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoScout.Startup))]
namespace AutoScout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
