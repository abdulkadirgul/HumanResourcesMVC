using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class CompanyAdminMap:BaseMap<CompanyAdmin>
    {
        public CompanyAdminMap()
        {
         

            ToTable("CompanyAdmin");
            Property(x => x.Email).HasColumnName("Email").HasMaxLength(255).IsRequired();
            Property(x => x.Password).HasColumnName("Password").IsRequired();
            Property(x => x.Username).HasColumnName("UserName").HasMaxLength(255).IsRequired();
        }
    }
}
