using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SmileFie.MobileAppService.Startup))]

namespace SmileFie.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}