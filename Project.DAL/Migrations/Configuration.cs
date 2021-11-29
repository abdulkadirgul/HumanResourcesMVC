namespace Project.DAL.Migrations
{
    using Project.ENTİTİES.Enums;
    using Project.ENTİTİES.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project.DAL.Context.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Project.DAL.Context.AppContext context)
        {
            if(!context.CompanyAdmins.Any() )
            {
                context.CompanyAdmins.Add(
                    new CompanyAdmin { Role = UserRole.Admin, Email = "admin@admin.com", Password="admin" });
            }
            
        }
    }
}
