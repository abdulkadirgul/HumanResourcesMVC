using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class DepartmentMap:BaseMap<Department>
    {
        public DepartmentMap()
        {
            ToTable("Departments");
            Property(x => x.NumberOfEmployee).HasColumnName("NumberOfEmployee").IsRequired();
            Property(x => x.LocationID).HasColumnName("LocationID");
           
        }
    }
}
