namespace PContactDemo.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PContactDemo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PContactDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PContactDemo.Models.ApplicationDbContext context)
        {

            try
            {
                //Roles de Administración de sistema 
                context.Roles.AddOrUpdate(a => a.Id, new IdentityRole
                {
                    Id = "c26a8b05-f431-4458-97d8-966209f8c2ee",
                    Name = "ADMINISTRATOR"
                });

                context.Users.AddOrUpdate(a => a.Id, new Models.ApplicationUser
                {
                    Id = "ac55797d-f2ed-499f-ad56-2fadeac9eac4",
                    Email = "admin@nimtech.com.mx",
                    PasswordHash = new PasswordHasher().HashPassword("Password1."),
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false,
                    LockoutEnabled = true,
                    TwoFactorEnabled = false,
                    AccessFailedCount = 0,
                    UserName = "admin@nimtech.com.mx",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    NombreCompleto = "Administrador"
                });

                var userAdmin = context.Set<ApplicationUser>().Find("ac55797d-f2ed-499f-ad56-2fadeac9eac4");
                if (!userAdmin.Roles.Any())
                {
                    userAdmin.Roles.Add(new IdentityUserRole
                    {
                        RoleId = "c26a8b05-f431-4458-97d8-966209f8c2ee",
                        UserId = "ac55797d-f2ed-499f-ad56-2fadeac9eac4"
                    });
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message, e.InnerException);
            }
          
        }
    }
}
