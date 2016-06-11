using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using MobileStore.ExceptionHandlers;

[assembly: OwinStartup(typeof(MobileStore.Startup))]

namespace MobileStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigureApi(app);
        }

        private void ConfigureApi(IAppBuilder app)
        {
            var httpConfiguration = new HttpConfiguration();

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
           // httpConfiguration.SuppressDefaultHostAuthentication();
          //  httpConfiguration.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            httpConfiguration.MapHttpAttributeRoutes();

            httpConfiguration.Services.Add(typeof(IExceptionLogger), new MobileStoreExceptionLogger());
            httpConfiguration.Services.Replace(typeof(IExceptionHandler),new MobileStoreExceptionHandler());

            app.UseWebApi(httpConfiguration);
        }
    }
}
