using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Models
{
  public  class Permission
    {
        public int Id { get; set; }
        public int ControllerName { get; set; }
        public virtual  ICollection<Action> Action { get; set; }
        public virtual ICollection<PermissionRoleMapping> PermissionRoleMapping { get; set; }

    }
}
