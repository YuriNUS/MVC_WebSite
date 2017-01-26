using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogicUniversity__AD_T4.Startup))]
namespace LogicUniversity__AD_T4
{
    public partial class Startup
    {
      

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
