using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Personel Sürücü Belgesi
    public class DrivingLicense:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime IssueDate { get; set; }
        public string CardNo { get; set; }
        public string LicenseClass { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime BirthDate { get; set; }

        //public int EmployeeID{ get; set; }
        public virtual List<Employee> Employee { get; set; }


    }
}
