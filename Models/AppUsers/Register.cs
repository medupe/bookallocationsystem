using System;
using System.Collections.Generic;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNetCore.Mvc;

namespace Bookallocationsystem.Models.AppUsers
{
    public class Register
    {
        [BindProperty]
        public string   Email { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string Password { get; set; }

         [BindProperty]
        public School School { get; set; }   
          public IEnumerable<School> SchoolList { get; set; }

    }
}
