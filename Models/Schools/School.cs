using System.ComponentModel.DataAnnotations;

namespace Bookallocationsystem.Models.Schools
{
    public class School
    {
        public int Id { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string SchoolNr { get; set; }
        [Required]
        public string SchoolAddress { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string CellNumber { get; set; }
        [Required]
        public string ContactPerson { get; set; }
        [Required]
        public string Email { get; set; }

    }
}