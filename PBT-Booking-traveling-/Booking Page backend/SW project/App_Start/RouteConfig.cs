﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SW_project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


               routes.MapRoute(
                name: null,
                url: "",
                defaults: new { controller = "Booking", action = "Index"}
            );

               routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Booking", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
