using System.ComponentModel.DataAnnotations;

namespace Bookallocationsystem.Models.Schools
{
    public class SchoolViewModelCreate
    {

        [Required(ErrorMessage = "School name is required")]

        public string SchoolName { get; set; }
        [Required(ErrorMessage = "School number is required")]

        public string SchoolNr { get; set; }
        [Required(ErrorMessage = "School address is required")]

        public string SchoolAddress { get; set; }
        [Required(ErrorMessage = "Province is required")]

        public string Province { get; set; }

        [Required(ErrorMessage = "Region is required")]
        public string Region { get; set; }
        [Required(ErrorMessage = "Contact  number is required")]

        public string CellNumber { get; set; }
        [Required(ErrorMessage = "Contact person  is required")]

        public string ContactPerson { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

    }
}