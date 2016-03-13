using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GraphAssesment.Client.Startup))]
namespace GraphAssesment.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
