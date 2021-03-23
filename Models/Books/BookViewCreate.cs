using System.Collections;
using System.Collections.Generic;
using bookallocationsystem.Models.Subjects;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Models.Books
{
    public class BookViewCreate
    {
        [BindProperty]
        public string Code { get; set; }
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string ISBN { get; set; }
        [BindProperty]
        public string Grade { get; set; }
        [BindProperty]
        public string GradeClass { get; set; }
     
        [BindProperty]
        public int SubjectId { get; set; }
        [BindProperty]
        public int SchoolId { get; set; }


        public IEnumerable<School> SchoolList { get; set; }
        public IEnumerable<Subject> SubjectList { get; set; }

    }
}