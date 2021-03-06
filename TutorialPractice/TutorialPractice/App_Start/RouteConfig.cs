﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TutorialPractice
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* please see the tutorial link : 
             * http://www.tutorialsteacher.com/mvc/action-method-in-mvc
             * and youtube link : 
             * https://www.youtube.com/watch?v=g2GbL4hPOMg&spfreload=1 
             * will explain the principle. */
            /*<--the default route--> || plz uncomment it.*/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            /* in Part 2 - CONTROLLER in Asp.net MVC | Role of Routing in MVC,
             * u can define your url pattern. */
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "GetName", id = UrlParameter.Optional }
            //);

            //for "TestController", if u want to run, please uncomment it.
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional }
            //);

            /*test for role_def's restful api.*/
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Test", action = "TestJson", id = UrlParameter.Optional }
            //);
        }
    }
}
