using Assignment1_EntityFrameworkAsp.NetMVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1_EntityFrameworkAsp.NetMVC.Startup))]
namespace Assignment1_EntityFrameworkAsp.NetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //let's add our role in startup.cs so that it can run on app startup
            CreateRolesAndUsers();
        }

        public void CreateRolesAndUsers()
        {
            var context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser
                {
                    UserName = "admin",
                    Email = "admin@me.com",
                    DateOfBirth = System.DateTime.Now
                };

                var password = "password";

                var usr = userManager.Create(user, password);

                if (usr.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "Admin");
                }
            }

            if (!roleManager.RoleExists("Staff"))
            {
                var role = new IdentityRole();
                role.Name = "Staff";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Student"))
            {
                var role = new IdentityRole();
                role.Name = "Student";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("SuperVisor"))
            {
                var role = new IdentityRole();
                role.Name = "SuperVisor";
                roleManager.Create(role);
            }
        }

        }
}
