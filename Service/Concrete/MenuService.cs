using System.Linq;
using DAL;
using ViewModels;
using Domin.Models;

namespace Services
{
    public class MenuService : BaseService<Menu>, IMenuService
    {
        private readonly IMenuRepository _repository;

        public MenuService(IMenuRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
        public IQueryable<MenuDataTableModel> GetForDataTable()
        {
            return _repository.GetForDataTable();
        }
    }
}