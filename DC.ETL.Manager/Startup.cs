using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DC.ETL.Manager.Startup))]
namespace DC.ETL.Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
