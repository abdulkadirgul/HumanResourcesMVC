using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Şirket departmanının birimleri
    public class Unit:BaseEntity
    {
        [Display(Name ="Personel Sayısı")]
        public int NumberOfEmployee { get; set; }

        //Bir birimin bir departmanı vardır.
        //public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
    }
}
