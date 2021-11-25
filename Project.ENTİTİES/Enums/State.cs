using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Enums
{
    public enum State
    {
        //Bekleyen-onaylanan izin, avans durumları

        [Display(Name ="Bekliyor")]
        Pending=0,

        [Display(Name ="Onaylandı")]
        Confirmed=1,

        [Display(Name ="Reddedildi")]
        Denied=2
    }
}
