using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC.Infrastructure
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly string[] allowedroles;
        public CustomAuthorizeAttribute(params string[] roles)
        {
            this.allowedroles = roles;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            
            var userRole = Convert.ToString(httpContext.Session["Perfil"]);
            foreach (var role in allowedroles)
            {
                if (role == userRole)
                {
                    return true;
                }

            }
            return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(

                new System.Web.Routing.RouteValueDictionary
                {
                    {"controller","User" },
                    {"action","Unauthorized" }
                });
        }

    }
}