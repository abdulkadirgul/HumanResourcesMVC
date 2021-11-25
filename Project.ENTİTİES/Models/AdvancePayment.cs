using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Avans Ödemesi
    public class AdvancePayment:BaseEntity
    {
        [Display(Name ="Miktar")]
        public double Amount { get; set; }

        [Display(Name ="Açıklama")]
        public string Description { get; set; }

        [Display(Name ="Talep Tarihi")]
        public DateTime IssueDate { get; set; }

        [Display(Name ="Onaylanma Tarihi")]
        public DateTime ConfirmedDate { get; set; }

        [Display(Name ="Durumu")]
        public State State { get; set; }

        [Display(Name ="Avans Tipi")]
        public AdvancePaymentType AdvancePaymentType { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
