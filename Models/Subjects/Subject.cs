using System.ComponentModel.DataAnnotations;

namespace bookallocationsystem.Models.Subjects
{
    public class Subject
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    
    }
}