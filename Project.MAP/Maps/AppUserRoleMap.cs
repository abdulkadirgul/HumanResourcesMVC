using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class AppUserRoleMap:BaseMap<AppUserRole>
    {
        public AppUserRoleMap()
        {
            ToTable("Roles");
        }
    }
}
