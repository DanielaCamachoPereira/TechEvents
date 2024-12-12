using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TechEvents.Models;

namespace TechEvents.App_Start
{
    public class RoleInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    { protected override void Seed(ApplicationDbContext context)
        { 
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (!roleManager.RoleExists("Administrador"))
            {
                var role = new IdentityRole("Administrador");
                roleManager.Create(role);
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com" };
                var userResult = userManager.Create(user, "admin123");
                if (userResult.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Administrador");
                }
            }
        }
    }
}