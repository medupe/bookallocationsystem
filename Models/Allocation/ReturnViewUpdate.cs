using Microsoft.AspNetCore.Mvc;

using System;
using bookallocationsystem.Models.Books;
using bookallocationsystem.Models.Learners;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;

namespace bookallocationsystem.Models.Allocation
{
    public class ReturnViewUpdate
    {
        public int  AllocateId { get; set; }
        [BindProperty]
         public bool Returned { get; set; }
               [BindProperty]
        public string ReturnedCondition { get; set; }
              [BindProperty]
        public DateTime ReturnedDate { get; set; }
              [BindProperty]
        public AppUser returnedBy { get; set; }
    }
}