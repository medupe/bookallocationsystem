using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bookallocationsystem.Models.Books;
using bookallocationsystem.Models.Learners;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;

namespace bookallocationsystem.Models.Allocation
{
    public class Allocate
    {
        public int Id { get; set; }
        [Required]
        public Learner Learner { get; set; }
        [Required]
        public School School { get; set; }
        [Required]
        public Book Book { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime AddedTime { get; set; } = DateTime.Now;
        [Required]
        public AppUser AddedBy { get; set; }

        [Required]
        public String AllocationCondition { get; set; }
        public bool Returned { get; set; }= false;
        public String ReturnedCondition { get; set; }
        public DateTime ReturnedDate { get; set; }
        public AppUser returnedBy { get; set; }
    }
}