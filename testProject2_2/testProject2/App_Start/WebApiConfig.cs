//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Http;

using DeLoachAero.WebApi; //for DefaultInlineConstraintResolver
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing; //for DefaultInlineConstraintResolver

namespace testProject2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
           // config.MapHttpAttributeRoutes();

            var constraintResolver = new DefaultInlineConstraintResolver();
            constraintResolver.ConstraintMap.Add("enum", typeof(EnumerationConstraint));
            config.MapHttpAttributeRoutes(constraintResolver);
            /*   config.Routes.MapHttpRoute(
                   name: "ProdApi",
                   routeTemplate: "api/prod/{id}",
                   defaults: new { controller = "products", id = RouteParameter.Optional }
                );

               config.Routes.MapHttpRoute(
                   name: "DefaultApi",
                   routeTemplate: "api/{controller}/{id}",
                   defaults: new { id = RouteParameter.Optional }
               );
               */
        }
    }
}
