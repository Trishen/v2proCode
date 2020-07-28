using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(v2proCode.Startup))]
namespace v2proCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
