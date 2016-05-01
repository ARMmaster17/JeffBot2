using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JeffBot2.Startup))]
namespace JeffBot2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
