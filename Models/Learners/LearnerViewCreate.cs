using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Models.Learners
{
    public class LearnerViewCreate
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]
        public string IdentityNumber { get; set; }
        [BindProperty]
        public string Grade { get; set; }
        [BindProperty]
        public string GradeClass { get; set; }

        public int SchoolId { get; set; }
        public int AddedBy { get; set; }
    }
}