﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _16_TranThanhHau_Buoi2_BTVN
{
    public class RouteConfig
    {
        //Bài 7,8,9,10
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        //    routes.MapRoute(
        //        name: "Default",
        //        url: "{controller}/{action}/{id}",
        //        defaults: new { controller = "Bai_78910", action = "Bai7", id = UrlParameter.Optional }
        //    );
        //}
        //Bài 11
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Bai11_HomePage", action = "Bai11_Home", id = UrlParameter.Optional }
            );
        }
    }
}