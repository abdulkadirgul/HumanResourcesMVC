using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //İzin Talepleri
    public class AllowRequest:BaseEntity
    {

        [Display(Name ="Açıklama")]
        public string Description { get; set; }

        [Display(Name = "İzin Talep Tarihi")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "İzin Onay Tarihi")]
        public DateTime ConfirmedDate { get; set; }

        [Display(Name = "İzin Başlama Tarihi")]
        public DateTime StartDate { get; set; }

        [Display(Name = "İzin Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        public State State { get; set; }

        public AllowType AllowType { get; set; }

        private byte totalAllowTime;

        public byte TotalAllowTime
        {
            get 
            {
                switch (AllowType)
                {
                    case AllowType.Annual:
                        return totalAllowTime = 14;
                    case AllowType.Death:
                        return totalAllowTime = 3;
                    case AllowType.Maternity:
                        return totalAllowTime = 120;
                    case AllowType.Disease:
                        return totalAllowTime = 10;
                    case AllowType.Military:
                        return totalAllowTime = 21;
                    default:
                        return totalAllowTime = 0;
                }

            }
            set { totalAllowTime = value; }
        }

        [Display(Name ="Şirket Açıklaması")]
        public string CompanyDescription { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employee Employee  { get; set; }

    }
}
