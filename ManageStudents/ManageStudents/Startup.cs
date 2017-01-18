using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageStudents.Startup))]
namespace ManageStudents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
