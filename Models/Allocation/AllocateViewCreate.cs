using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using bookallocationsystem.Models.Books;
using bookallocationsystem.Models.Learners;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Models.Allocation
{
    public class AllocateViewCreate
    {

        [BindProperty]
        public int LearnerId { get; set; }

        public int? SchoolId { get; set; }=0;

        public int? BookId { get; set; }=1;


        public int? AddedBy { get; set; }=0;

        [BindProperty]
        public String AllocationCondition { get; set; }

        public IEnumerable<Learner> LearnerList { get; set; }
        public Book Book { get; set; }

    }
}