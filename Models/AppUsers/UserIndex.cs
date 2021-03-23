
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Bookallocationsystem.Models.AppUsers
{
    public class UserIndex
    {
              public UserIndex()
        {
            this.userList = new List<AppUser>();
        }
        public List<AppUser> userList { get; set; }
        
    }
}
