using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class CompanyAdmin:BaseEntity
    {
        public CompanyAdmin()
        {
            Username = "admin";
            Password = "1234";
            Email = "admin@gmail.com";
            Role =UserRole.Admin;
            IsActive = true;
            ActivationCode = new Guid();
         
        }
        [Display(Name ="Kullanıcı Adı")]
        public string Username { get; set; }

        [Display(Name ="Şifre")]
        public string Password { get; set; }

        [Display(Name ="Email")]
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public Guid ActivationCode { get; set; }
        public UserRole Role { get; set; }
        public List<Department> Departments { get; set; }
        public List<Employee> Employees{ get; set; }
    }
}
