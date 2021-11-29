using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Masraflar
    public class Expense:BaseEntity
    {
        [Display(Name ="Açıklama")]
        public string Description { get; set; }

        [Display(Name ="Masraf Miktarı")]
        public double Amount { get; set; }

        public bool IsConfirmed { get; set; }
        public State State { get; set; }

        //Bir masraf bir çalışana aittir - Navigation
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
