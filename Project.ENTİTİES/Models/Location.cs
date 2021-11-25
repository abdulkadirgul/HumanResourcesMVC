using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Şirket Lokasyonları
    public class Location:BaseEntity
    {
        //public int DepartmentID { get; set; }

        //Bir lokasyonda birden fazla şirket departmanı bulunabilir.
        public virtual List<Department> Departments { get; set; }
    }
}
