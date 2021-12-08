using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class AppUserAndRoleMap:BaseMap<AppUserAndRole>
    {
        public AppUserAndRoleMap()
        {
            Ignore(x => x.ID);
            HasKey(x => new { x.AppUserID, x.AppUserRoleID });
        }
    }
}
