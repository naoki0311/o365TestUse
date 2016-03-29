using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Office_365_Test_Project.Startup))]
namespace Office_365_Test_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
