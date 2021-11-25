using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
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
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public Guid ActivationCode { get; set; }
        public UserRole Role { get; set; }
        public List<Department> Departments { get; set; }
    }
}
