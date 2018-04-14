using System.Linq;
using Domin.Models;
using Infrastructure;
using ViewModels;

namespace DAL
{
    public interface IMenuRepository : IRepository<Menu>
    {
        IQueryable<MenuDataTableModel> GetForDataTable();
    }
}