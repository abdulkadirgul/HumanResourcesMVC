namespace Project.DAL.Migrations
{
    using Project.ENTİTİES.Enums;
    using Project.ENTİTİES.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project.DAL.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Project.DAL.Context.AppDbContext context)
        {
            AppUserRole appUserRole = new AppUserRole()
            {
                ID = new int(),
                Role = "Admin",
                CreatedDate = DateTime.Now
            };

            AppUser appUser = new AppUser()
            {
                ID = 1,
                UserName = "Admin",
                Password = "1234",
                Email = "admin@gmail.com"

            };

        }
    }
}

