using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Services;
using DAL;
using Infrastructure;
using Microsoft.AspNet.Identity;
using ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using ShoppingWebSite.Areas.Admin.Controllers;

namespace ShoppingWebSite
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IMenuRepository, MenuRepository>();
            container.RegisterType<IMenuService, MenuService>();
            //container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
           // container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            return container;
        }
    }
}