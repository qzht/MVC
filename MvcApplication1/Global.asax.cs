using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // 路由名称
                "{controller}/{action}/{id}", // 带有参数的 URL
                new { controller = "News", action = "News", id = UrlParameter.Optional }// 参数默认值
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            //ViewEngines.Engines.Clear();
            //ViewEngines.Engines.Add(new Engine());
        }
    }
    public class Engine : RazorViewEngine
    {

        public Engine()
        {

            base.AreaViewLocationFormats = new string[]

            {

                "~/Areas/{2}/Views/{1}/{0}.cshtml",

                "~/Areas/{2}/Views/Shared/{0}.cshtml",

            };

            base.AreaMasterLocationFormats = new string[]

            {

                "~/Areas/{2}/Views/{1}/{0}.cshtml",

                "~/Areas/{2}/Views/Shared/{0}.cshtml",

                

            };

            base.AreaPartialViewLocationFormats = new string[]

            {

                "~/Areas/{2}/Views/{1}/{0}.cshtml",

                "~/Areas/{2}/Views/Shared/{0}.cshtml",

            };

            base.ViewLocationFormats = new string[]

            {

                "~/Views/{1}/{0}.cshtml",

                "~/Views/Shared/{0}.cshtml",

            };

            base.MasterLocationFormats = new string[]

            {

                "~/Views/{1}/{0}.cshtml",

                "~/Views/Shared/{0}.cshtml",

            };

            base.PartialViewLocationFormats = new string[]

            {

                "~/Views/{1}/{0}.cshtml",

                "~/Views/Shared/{0}.cshtml",

            };

            base.FileExtensions = new string[]

            {

                "cshtml",

            };

        }

    }
}