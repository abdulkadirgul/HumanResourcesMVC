using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class UnitMap:BaseMap<Unit>
    {
        public UnitMap()
        {
            ToTable("Units");
            Property(x => x.NumberOfEmployee).HasColumnName("NumberOfEmployee").IsRequired();
          
        }
    }
}
