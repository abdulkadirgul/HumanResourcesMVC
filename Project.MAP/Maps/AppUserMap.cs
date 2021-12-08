using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("Users");
            Property(x => x.UserName).IsRequired();
            Property(x => x.UserName).HasMaxLength(50);
            Property(x => x.Password).IsRequired();
            Property(x => x.Email).IsRequired();
            
        }
    }
}
