using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTAREA1.Startup))]
namespace MVCTAREA1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
