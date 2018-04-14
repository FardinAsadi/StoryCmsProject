using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Security.Claims;
using Infrastructure;

namespace ShoppingWebSite.App_Start
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public string RoleName { get; set; }
        //public CustomAuthorizeAttribute(string rolename)
        //{
        //    RoleName = rolename;
        //}
        public override void OnAuthorization(AuthorizationContext filterContext)
        {



            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            var AllAttributes = filterContext.ActionDescriptor.GetCustomAttributes(false);
            bool noauthorize = false;
            foreach (var item in AllAttributes)
            {
                if (item.GetType().Name == typeof(AllowAnonymousAttribute).Name)
                {
                    noauthorize = true;
                }

            }
            if (!noauthorize)
            {
                if (AuthorizeCore(filterContext.HttpContext))
                {

                }


            }

        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }


            if (!httpContext.User.Identity.IsAuthenticated)
            {
                httpContext.Response.RedirectToRoute(new RouteValueDictionary(

                   new
                   {
                       Areas = "Admin",
                       controller = "Account",
                       action = "Login"
                   })
               );
            }


            else if (!httpContext.User.IsInRole(RoleName))
            {
                httpContext.Response.RedirectToRoute(new RouteValueDictionary(

                  new
                  {
                      Areas = "Admin",
                      controller = "Account",
                      action = "Error"
                  })
              );
            }
            return true;
        }
        //protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        //{

        //    filterContext.Result = new RedirectToRouteResult(
        //        new RouteValueDictionary(

        //            new
        //            {
        //                Areas = "Admin",
        //                controller = "Account",
        //                action = "Login"
        //            })
        //        );
        //    //  base.HandleUnauthorizedRequest(filterContext);
        //}
    }
}