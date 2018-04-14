using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Models
{
  public  class Action
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public int ActionName { get; set; }
        public virtual  Permission Permission { get; set; }
    }
}
