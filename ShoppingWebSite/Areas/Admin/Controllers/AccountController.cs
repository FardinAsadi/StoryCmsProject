using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ViewModels;
namespace ShoppingWebSite.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        //    private ApplicationSignInManager _signInManager;
        //    private ApplicationUserManager _userManager;

        public AccountController()
        {
        }
        [AllowAnonymous]
        public ActionResult Error()
        {

            return View("Error");
        }


        // GET: /Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            var result = userManager.ChangePassword(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            if (result.Succeeded)
            {
                var user = userManager.FindById(User.Identity.GetUserId());
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                if (user != null)
                {
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                }
                return RedirectToAction("Index", new { Message = "ManageMessageId.ChangePasswordSuccess" });
            }
            AddErrors(result);
            return View(model);
        }
        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model,string returnUrl)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            
            var user = userManager.Find(model.Email, model.Password);

            if (user != null)
            {
                var authenticationManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                RedirectToLocal(returnUrl);
            }
            else
            {
                return RedirectToAction("Login", "Account");
                //// StatusText.Text = "Invalid username or password.";
                //  LoginStatus.Visible = true;
            }
            return RedirectToAction("Index", "Menus");
        }


        [AllowAnonymous]
        public ActionResult Register()
        {
      //      var RoleStore = new RoleStore<IdentityRole>();
      //      var RoleStoremanager = new RoleManager<IdentityRole>(RoleStore);
      //      var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
      //      role.Name = "Admin";
      //var ro=RoleStoremanager.Create(role);

            var JH = User.IsInRole("Admin");
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            var user = manager.Find("fardinasadi7@gmail.com", "3521827Fa*");
            var rolee = manager.GetRoles(user.Id);
            manager.AddToRole(user.Id, "Admin");
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {

            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
       
            var user = new IdentityUser() { UserName = model.Email };
            
            IdentityResult result = manager.Create(user, model.Password);

            if (result.Succeeded)
            {
                var authenticationManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
              
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
                Response.Redirect("Admin/Menus/Index");
            }
            else
            {
                // StatusMessage.Text = result.Errors.FirstOrDefault();
            }
            return RedirectToAction("Index", "Menus");
        }
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            var authenticationManager = HttpContext.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            return null; 
        }
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}