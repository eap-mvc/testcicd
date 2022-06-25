using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestCICD.Startup))]
namespace TestCICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
