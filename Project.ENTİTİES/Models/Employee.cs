using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{ 
    //Personel
   public class Employee:BaseEntity
    {
        [Required(ErrorMessage ="TC Kimlik No Girilmesi Zorunludur!")]
        [Display(Name ="TC Kimlik No")]
        public string TCKNo { get; set; }


        [Required(ErrorMessage = "İsim Girilmesi Zorunludur!")]
        [Display(Name ="Adı")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim Girilmesi Zorunludur!")]
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }
        public string SGKNo { get; set; }

        [Display(Name ="İşe Başlama Tarihi")]
        public DateTime İseBaslama { get; set; }

        [Display(Name ="Giriş Zamanı")]
        public DateTime CheckInTime { get; set; }

        [Display(Name = "Çıkış Zamanı")]
        public DateTime CheckInOutTime { get; set; }

       

        public int AllowRequestID { get; set; } //Bir çalışanın birden fazla izin isteği vardır.
        public int AdvancePaymentID { get; set; } //Bir çalışanın birden fazla avans ödemesi vardır.
        public int ExpenseID { get; set; } //Bir çalışanın birden fazla masrafı vardır.
        public int ExtraWorktimeID { get; set; } //Bir çalışanın birden fazla mesaisi vardır.

        //Mapping Properties

        
        public virtual List<AllowRequest> AllowRequests { get; set; }
        public virtual List<AdvancePayment> AdvancePayments { get; set; }
        public virtual List<Expense> Expenses { get; set; }
        public virtual  List<ExtraWorktime> ExtraWorktimes { get; set; }
    }
}
