using System.ComponentModel.DataAnnotations;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;

namespace bookallocationsystem.Models.Learners
{
    public class Learner
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public string Grade { get; set; }
        [Required]
        public string GradeClass { get; set; }
        [Required]
        public School school { get; set; }
        [Required]
        public AppUser AddedBy { get; set; }


    }
}