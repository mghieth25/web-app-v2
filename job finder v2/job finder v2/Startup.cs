using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(job_finder_v2.Startup))]
namespace job_finder_v2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
