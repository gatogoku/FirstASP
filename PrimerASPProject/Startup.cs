using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrimerASPProject.Startup))]
namespace PrimerASPProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
