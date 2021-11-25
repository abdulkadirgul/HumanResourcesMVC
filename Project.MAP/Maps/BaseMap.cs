using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class BaseMap<T>:EntityTypeConfiguration<T> where T:BaseEntity
    {
        //public BaseMap()
        //{
        //    //Property(x => x.CreatedDate).HasColumnName("CreatedDate");
        //    //Property(x => x.DeletedDate).HasColumnName("DeletedDate");
        //    //Property(x => x.ModifiedDate).HasColumnName("ModifiedDate");

        //}
        
    }
}
