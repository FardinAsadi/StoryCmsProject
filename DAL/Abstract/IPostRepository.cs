using System;
using System.Linq;
using Domin.Models;
using Infrastructure;
namespace DAL
{
    public interface IPostRepository : IRepository<Post>
    {
      //  IQueryable<CountryDataTableModel> GetForDataTable();
    }
}
