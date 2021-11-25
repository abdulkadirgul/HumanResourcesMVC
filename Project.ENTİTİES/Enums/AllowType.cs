using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Enums
{
    //İzin Tipleri
    public enum AllowType
    {
        [Display(Name ="Yıllık İzin")]
        Annual=1,

        [Display(Name ="Ölüm izni")]
        Death=2,

        [Display(Name ="Annelik İzni")]
        Maternity=3,

        [Display(Name ="Hastalık İzni")]
        Disease=4,

        [Display(Name ="Askerlik İzni")]
        Military=5
    }
}
