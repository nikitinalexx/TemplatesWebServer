using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebClient.Startup1))]

namespace WebClient
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.Run(context =>
            {
                return context.Response.WriteAsync("WebServer with Templates is running");
            });
        }
    }
}
