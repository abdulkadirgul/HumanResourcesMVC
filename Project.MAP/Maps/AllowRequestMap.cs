using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class AllowRequestMap:BaseMap<AllowRequest>
    {
        public AllowRequestMap()
        {
            ToTable("AllowRequests");
            //Ignore(x => x.ID).HasKey(x => new { x.EmployeeID});
            Property(x => x.AllowType).IsRequired();
            Property(x => x.CompanyDescription).IsOptional();
            Property(x => x.Description).IsOptional();
        }
    }
}
