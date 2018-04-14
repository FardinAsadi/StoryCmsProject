

using System;
using System.Linq;
using Domin.Models;
using Infrastructure;
using ViewModels;

namespace DAL
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {

        public MenuRepository()
        {

        }
        public IQueryable<MenuDataTableModel> GetForDataTable()
        {
            return  unitofwork.context.Menu.Select(x => new MenuDataTableModel()
            {

                Id = x.Id,

                Name = x.Name,

                Link = x.Link,
                Row = 0
            });
        }


    }
}
