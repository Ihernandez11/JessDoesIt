using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JessDoesIt.Startup))]
namespace JessDoesIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
