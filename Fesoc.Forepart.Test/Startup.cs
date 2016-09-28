using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fesoc.Forepart.Test.Startup))]
namespace Fesoc.Forepart.Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
