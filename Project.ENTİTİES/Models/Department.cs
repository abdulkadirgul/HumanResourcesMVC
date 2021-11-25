using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Şirket Departmanları
    public class Department:BaseEntity
    {
        [Display(Name ="Personel Sayısı" )]
        public int NumberOfEmployee { get; set; }

        //Bir Departman sadece bir lokasyonda bulunur.
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

        //Bir Departmanın birden fazla birimi vardır
        public virtual List<Unit> Units { get; set; }
    }
}
