using System.Linq;
using DataTablesParser;
using Domin.Models;
using ViewModels;
using Services;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Web;

namespace ShoppingWebSite.Areas.Admin.Controllers
{
    public class MenusController : BaseController
    {
		private readonly IMenuService _menuService;
        
		public MenusController(IMenuService menuService)
        {
            _menuService = menuService;
        }
        // GET: /Admin/Menus/
        public ActionResult Index()
        {
           
            var model = new Menu();
            return View(model);
        }
		public JsonResult List()
        {
            var data = _menuService.GetForDataTable();
            var parser = new DataTablesParser<MenuDataTableModel>(Request, data);
            var counter = 1;
            var result = parser.Parse();
            foreach (var item in result.data)
            {
                item.Row = counter++;
            }
            return Json(result);
        }
        // GET: /Admin/Menus/Details/5
        public ActionResult GetById(int id)
        {
            var item = _menuService.GetById(id);
        
            var model = new MenuJsonModel() {

			
        Id = item.Id,
    
        Name = item.Name,
    
        Link = item.Link,
    			 
			 };
            
                        return Json(model, JsonRequestBehavior.AllowGet);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Menu menu)
        {
            var result = false;
            if (ModelState.IsValid)
            {
                
                result = _menuService.Create(menu);
            }

                                        return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Menu menu)
        {
		var result = false;
            if (ModelState.IsValid)
            {
                result = _menuService.Update(menu);
                
                
            }
            return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

        

        // POST: /Admin/Menus/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Menu menu =  _menuService.GetById(id);
            var result = _menuService.Delete(menu);
            
            return Json(new { result }, JsonRequestBehavior.AllowGet);
        }

    }
}
