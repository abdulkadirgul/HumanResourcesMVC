using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Fazla Çalışma Zamanı
    public class ExtraWorktime:BaseEntity
    {
        [Display(Name ="Açıklama")]
        public string Description { get; set; }

        [Display(Name ="Fazla Mesai Başlama Zamanı")]

        private DateTime? startDate;

        public DateTime StartDate
        {
            get { return this.startDate.HasValue?  this.startDate.Value : DateTime.Now; }
            set { this.startDate = value; }

        }

        [Display(Name ="Fazla Mesai Bitiş Zamanı")]
        public DateTime EndTime { get; set; }

        [Display(Name ="Onaylanma Zamanı")]

        public DateTime ConfirmedTime { get; set; }
        public bool IsConfirmed { get; set; }
        public State State { get; set; }

        //Bir fazla çalışma zamanı bir çalışana aittir
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }


    }
}
