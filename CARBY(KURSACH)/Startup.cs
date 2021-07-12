using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CARBY_KURSACH_.Startup))]
namespace CARBY_KURSACH_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
