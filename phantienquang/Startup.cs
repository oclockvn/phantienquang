using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phantienquang.Startup))]
namespace phantienquang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
