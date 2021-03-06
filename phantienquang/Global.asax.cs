﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace phantienquang
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DependencyConfig.Register();
            MapperConfig.Register();
        }

        protected void Application_Error()
        {
            
        }
    }
}
