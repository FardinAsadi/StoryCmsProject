using System;
using System.Linq;
using Domin.Models;
using Infrastructure;
namespace DAL
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        
        public PostRepository() 
        {

        }

   
    }
}
