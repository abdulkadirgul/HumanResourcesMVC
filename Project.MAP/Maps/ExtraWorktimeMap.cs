using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class ExtraWorktimeMap:BaseMap<ExtraWorktime>
    {
        public ExtraWorktimeMap()
        {
            ToTable("ExtraWorktimes");
            //Ignore(x => x.ID).HasKey(x=> new {x.EmployeeID });
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired();
            Property(x => x.EndTime).HasColumnName("EndDate").IsRequired();
            Property(x => x.Description).IsOptional();
        }
    }
}
