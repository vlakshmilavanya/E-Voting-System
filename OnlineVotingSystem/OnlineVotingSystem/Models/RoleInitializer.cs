using Microsoft.AspNetCore.Identity;
using OnlineVotingSystem.Areas.Identity.Data;
using OnlineVotingSystem.Data;

namespace OnlineVotingSystem.Models
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(OnlineVotingSystemContext context, IServiceProvider serviceProvider,
            UserManager<OnlineVotingSystemUser> userManager)
        {
            var Role = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "Voter", "Candidate" };
            IdentityResult result;
            foreach(var name in roleNames)
            {
                var roleExists = await Role.RoleExistsAsync(name);
                if(!roleExists)
                {
                    result = await Role.CreateAsync(new IdentityRole(name));
                }
            }

            string Email = "admin@gmail.com";
            string Password = "Admin@123";
            if(userManager.FindByEmailAsync(Email).Result == null)
            {
                OnlineVotingSystemUser user = new OnlineVotingSystemUser();
                user.UserName = Email;
                user.Email = Email;
                IdentityResult identityResult = userManager.CreateAsync(user, Password).Result;

                if(identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
         }
    }
}
