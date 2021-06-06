using System;
using bookallocationsystem.Models.Allocation;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Models.Audits
{
    public class AuditViewCreate
    {
       
        [BindProperty]
        public string AuditQuater { get; set; }
        [BindProperty]
          public string AuditCondition { get; set; }
    
        [BindProperty]
        public int AllocateId { get; set; }
        public Allocate allocation { get; set; }
        public int AuditBy { get; set; }

    }
}