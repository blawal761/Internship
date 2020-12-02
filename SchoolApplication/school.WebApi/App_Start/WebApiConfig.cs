﻿using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace school.WebApi.App_Start
{
    public static class WebApiConfig
    {
        //public static StandardKernel Register(HttpConfiguration config)
        //{
        //    config.Filters.Add(new AuthorizeAttribute());
        //    var kernel = new StandardKernel();
        //    Register(config, kernel);
        //    return kernel;
        //}
        public static void Register(HttpConfiguration config)
        {
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            Standa kernal = new Standrakrtn();

           // EnableCorsAttribute cors = new EnableCorsAttribute("*","*","*");
            //config.EnableCors(cors);
        }
    }
}