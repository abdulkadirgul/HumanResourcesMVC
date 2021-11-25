using Project.ENTİTİES.Models;
using Project.MAP.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class AppContext:DbContext
    {

        public AppContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-0HVGQBS\\SQLEXPRESS;database=HRProjectDB;integrated security=true";
        }

        public DbSet<AdvancePayment> AdvancePayments { get; set; }
        public DbSet<AllowRequest> AllowRequests { get; set; }
        public DbSet<CompanyAdmin> CompanyAdmins { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DrivingLicense> DrivingLicenses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeCard> EmployeeCards { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExtraWorktime> ExtraWorktimes { get; set; }
        public DbSet<Location> Locations  { get; set; }
        public DbSet<Unit> Units { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdvancePaymentMap());
            modelBuilder.Configurations.Add(new AllowRequestMap());
            modelBuilder.Configurations.Add(new CompanyAdminMap());
            modelBuilder.Configurations.Add(new DepartmentMap()); 
            modelBuilder.Configurations.Add(new DrivingLicenseMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeCardMap());
            modelBuilder.Configurations.Add(new ExpenseMap());
            modelBuilder.Configurations.Add(new ExtraWorktimeMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new UnitMap());
            
                     
            base.OnModelCreating(modelBuilder);
        }

    }
}
