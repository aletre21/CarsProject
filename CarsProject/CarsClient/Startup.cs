using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsClient.Startup))]
namespace CarsClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
