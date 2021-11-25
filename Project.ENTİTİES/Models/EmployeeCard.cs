using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    //Personel Kimlik Belgesi
    public class EmployeeCard:BaseEntity
    {
        public string TCKNo { get; set; }
        public string SerialNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string BloodGroup { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuePlace { get; set; }
        public string Religion { get; set; }
        public string RegisteredProvince { get; set; }
        public string RegisteredCountry { get; set; }
        public string RegisteredVillage { get; set; }
        public string MaritalStatus { get; set; }
        public string VolumeNumber { get; set; }
        public string FamilyNo { get; set; }
        public string RowNo { get; set; }
        public string EnrollmentNo { get; set; }
        public string MotherLastName { get; set; }

        //public int EmployeeID { get; set; }
        public virtual List<Employee> Employee { get; set; }
       
    }
}
