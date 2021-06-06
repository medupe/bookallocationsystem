using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bookallocationsystem.Models.Subjects;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;

namespace bookallocationsystem.Models.Books
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Grade { get; set; }
        [Required]
        public string GradeClass { get; set; }
        [Required]
        public AppUser AddedBy { get; set; }
        [Required]
        public Subject Subject { get; set; }
        [Required]
        public School School { get; set; }
        [Required]
        public string Condition { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime AddedTime { get; set; } = DateTime.Now;


    }
}