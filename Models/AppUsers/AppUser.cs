
using System.Security.Claims;
using System.Threading.Tasks;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNetCore.Identity;

namespace Bookallocationsystem.Models.AppUsers
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public School School { get; set; }
        
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            var authenticationType = "Put authentication type Here";
            var userIdentity = new ClaimsIdentity(await manager.GetClaimsAsync(this), authenticationType);

            // Add custom user claims here
            return userIdentity;
        }

    }
}
