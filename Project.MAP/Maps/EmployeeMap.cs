using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class EmployeeMap:BaseMap<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Employees");
            Property(x => x.TCKNo).HasColumnName("TCKNo").HasMaxLength(11).IsRequired();
            Property(x => x.FirstName).HasColumnName("FirstName").HasMaxLength(255).IsRequired();
            Property(x => x.LastName).HasColumnName("LastName").HasMaxLength(255).IsRequired();
            Property(x => x.CheckInTime).HasColumnName("CheckİnTime").IsRequired();
            Property(x => x.CheckInTime).HasColumnName("CheckİnOutTime").IsRequired();
            Property(x => x.İseBaslama).HasColumnName("İseBaslama").IsRequired();
            

        }
    }
}
