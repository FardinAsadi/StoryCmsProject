using System.Linq;
using ViewModels;
using Domin.Models;

namespace Services
{
    public interface IMenuService : IBaseService<Menu>
    {
        IQueryable<MenuDataTableModel> GetForDataTable();
    }
}