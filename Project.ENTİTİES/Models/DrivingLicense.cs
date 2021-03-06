using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Personel Sürücü Belgesi
    public class DrivingLicense:BaseEntity
    {
        [Display(Name = "Adı")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadı")]
        public string LastName { get; set; }

        [Display(Name = "Veriliş Tarihi")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "Kart Numarası")]
        public string CardNo { get; set; }

        [Display(Name ="Ehliyet Sınıfı")]
        public string LicenseClass { get; set; }

        [Display(Name = "Baba Adı")]
        public string FatherName { get; set; }

        [Display(Name = "Anne Adı")]
        public string MotherName { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }




    }
}
