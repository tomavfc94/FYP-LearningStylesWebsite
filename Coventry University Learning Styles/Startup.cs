using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coventry_University_Learning_Styles.Startup))]
namespace Coventry_University_Learning_Styles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
