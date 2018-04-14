using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Models
{
    public class PermissionRoleMapping
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public string AspNetRolesId  { get; set; }
        public string AspNetUsersId { get; set; }
        public virtual Permission Permission{ get; set; }
        public virtual AspNetRoles AspNetRoles { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
    
}
