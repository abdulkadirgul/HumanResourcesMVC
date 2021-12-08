using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre Giriniz!")]
        public string Password { get; set; }
    }
}
