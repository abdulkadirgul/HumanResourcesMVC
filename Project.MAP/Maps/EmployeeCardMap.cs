using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class EmployeeCardMap:BaseMap<EmployeeCard>
    {
        public EmployeeCardMap()
        {
            ToTable("EmployeeCards");
            Property(x => x.TCKNo).HasColumnName("EmployeeCards").IsRequired();
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired();
            Property(x => x.LastName).HasColumnName("LastName").IsRequired();


        }
    }
}
