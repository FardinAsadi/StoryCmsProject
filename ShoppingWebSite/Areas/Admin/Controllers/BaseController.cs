using Microsoft.AspNet.Identity;
using ShoppingWebSite.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShoppingWebSite.Areas.Admin.Controllers
{
    [CustomAuthorize(RoleName = "Admin")]
    public class BaseController : Controller
    {
        public BaseController()
        {

        }
        protected ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }   
    }
}