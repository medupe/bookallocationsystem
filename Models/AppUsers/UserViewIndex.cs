using System.Collections.Generic;
using Bookallocationsystem.Models.AppUsers;

namespace bookallocationsystem.Models.AppUsers
{
    public class UserViewIndex
    {
        public UserViewIndex()
        {
            this.userList = new List<AppUser>();
        }
        public List<AppUser> userList { get; set; }
    }
}