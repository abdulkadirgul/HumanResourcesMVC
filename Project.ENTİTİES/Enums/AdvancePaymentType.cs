using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Enums
{
    //Avans Tipleri
    public enum AdvancePaymentType
    {
        [Display(Name ="İş Avansı")]
        JobAdvance=1,

        [Display(Name ="Maaş Avansı")]
        SalaryAdvance=2

    }
}
