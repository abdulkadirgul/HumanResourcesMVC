using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
   public class AppUserAndRole : BaseEntity
    {
        public int AppUserID { get; set; }
        public int AppUserRoleID { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual AppUserRole AppUserRole { get; set; }
    }
}
