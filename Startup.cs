using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200394114Lesson3.Startup))]
namespace _200394114Lesson3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
