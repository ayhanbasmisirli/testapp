using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using testapp.Controllers;

namespace testapp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "",new {controller="Home",action="index"},new []{typeof (HomeController).Namespace});
            //default home route action index with default namespace with homecontroller
            routes.MapRoute("Register", "register", new {controller = "Register",action="register"});
        }
    }
}