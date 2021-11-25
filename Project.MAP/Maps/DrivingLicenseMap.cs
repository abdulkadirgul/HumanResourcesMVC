using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class DrivingLicenseMap:BaseMap<DrivingLicense>
    {
        public DrivingLicenseMap()
        {
            ToTable("DrivingLicenses");
            Property(x => x.FirstName).HasColumnName("FirstName").HasMaxLength(255).IsRequired();
            Property(x => x.LastName).HasColumnName("LastName").HasMaxLength(255).IsRequired();
            Property(x => x.LicenseClass).HasColumnName("LicenseClass").IsRequired();
            Property(x => x.IssueDate).HasColumnName("IssueDate").IsRequired();
            Property(x => x.CardNo).HasColumnName("CardNo").HasMaxLength(255).IsRequired();
            Property(x => x.BirthDate).HasColumnName("BirtDate").IsRequired();
            Property(x => x.FatherName).IsOptional();
            Property(x => x.MotherName).IsOptional();


        }
    }
}
