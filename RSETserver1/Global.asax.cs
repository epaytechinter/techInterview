using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace RSETserver1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // GlobalConfiguration.Configure(RouteConfig.RegisterRoutes);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
