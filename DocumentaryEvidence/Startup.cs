using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocumentaryEvidence.Startup))]
namespace DocumentaryEvidence
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
