using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommerceClient.Startup))]
namespace CommerceClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
