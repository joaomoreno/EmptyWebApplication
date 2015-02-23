using Microsoft.AspNet.Builder;
// w

namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseWelcomePage();
        }
    }
}
