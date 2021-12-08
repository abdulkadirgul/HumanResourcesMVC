using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class BaseEntity
    {
        public int ID { get; set; }

        [Display(Name ="Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Değiştirilme Tarihi")]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Silinme Tarihi")]

        public DateTime? DeletedDate { get; set; }

        [Display(Name ="Durumu")]
        public DataStatus Status { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Active;
        }


    }
}
