using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Personel Kimlik Belgesi
    public class EmployeeCard:BaseEntity
    {
        [Display(Name ="TC Kimlik No")]
        [Required(ErrorMessage ="Girilmesi zorunludur!")]
        public string TCKNo { get; set; }

        [Display(Name = "Seri No")]
        [Required(ErrorMessage = "Girilmesi zorunludur!")]
        public string SerialNo { get; set; }

        [Display(Name = "Adı")]
        [Required(ErrorMessage = "Girilmesi zorunludur!")]
        public string FirstName { get; set; }

        [Display(Name = "Soyadı")]
        [Required(ErrorMessage = "Girilmesi zorunludur!")]
        public string LastName { get; set; }

        [Display(Name = "Baba Adı")]
        [Required(ErrorMessage = "Girilmesi zorunludur!")]
        public string FatherName { get; set; }

        [Display(Name = "Anne Adı")]
        [Required(ErrorMessage = "Girilmesi zorunludur!")]
        public string MotherName { get; set; }

        [Display(Name = "Doğum Yeri")]
        [Required(ErrorMessage = "Girilmesi zorunludur!")]
        public string BirthPlace { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [Required(ErrorMessage = "Girilmesi zorunludur!")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Kan Grubu")]
        public string BloodGroup { get; set; }

        [Display(Name = "Veriliş Tarihi")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "Veriliş Yeri")]
        public string IssuePlace { get; set; }

        [Display(Name = "Dini")]
        public string Religion { get; set; }
        public string RegisteredProvince { get; set; }
        public string RegisteredCountry { get; set; }
        public string RegisteredVillage { get; set; }

        [Display(Name = "Medeni Durumu")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Sıra No")]
        public string VolumeNumber { get; set; }

        [Display(Name = "Aile No")]
        public string FamilyNo { get; set; }

        [Display(Name = "Kütük No")]
        public string RowNo { get; set; }
        public string EnrollmentNo { get; set; }

        [Display(Name = "Anne Kızlık Soyadı")]
        public string MotherLastName { get; set; }



    }
}
