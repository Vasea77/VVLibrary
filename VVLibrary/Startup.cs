using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VVLibrary.Startup))]
namespace VVLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
