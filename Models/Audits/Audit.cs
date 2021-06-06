using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bookallocationsystem.Models.Allocation;
using Bookallocationsystem.Models.AppUsers;

namespace bookallocationsystem.Models.Audits
{
    public class Audit
    {
        public int Id { get; set; }
        [Required]
        public string AuditQuater { get; set; }

             public string AuditCondition{ get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime AuditDate { get; set; } = DateTime.Now;
        [Required]
        public Allocate Allocate { get; set; }
        public AppUser AuditBy { get; set; }







    }
}