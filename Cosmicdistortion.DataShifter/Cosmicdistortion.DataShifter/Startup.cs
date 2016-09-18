using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cosmicdistortion.DataShifter.Startup))]
namespace Cosmicdistortion.DataShifter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
