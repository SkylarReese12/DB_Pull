﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;

namespace DB_Pull
{
    public class Global : HttpApplication
    {

        protected void Application_BeginRequest()
        {
            string[] allowedOrigin = new string[] { "http://localhost:51315/" };
            var origin = HttpContext.Current.Request.Headers["Origin"];
            if (origin != null && allowedOrigin.Contains(origin))
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allowed-Origin", origin);
                HttpContext.Current.Response.AddHeader("Access-Control-Allowed-Methods", "GET, POST");
            }
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }

    }
}