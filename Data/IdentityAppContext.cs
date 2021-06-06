
using Bookallocationsystem.Models.AppUsers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Bookallocationsystem.Models.Schools;
using bookallocationsystem.Models.Subjects;
using bookallocationsystem.Models.Books;
using Microsoft.Extensions.Configuration;
using bookallocationsystem.Models.Learners;
using bookallocationsystem.Models.Audits;
using bookallocationsystem.Models.Allocation;

namespace Bookallocationsystem.Data
{
    public class IdentityAppContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> otp) : base(otp)
        {
            // Microsoft.Extensions.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<School> School { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Learner> Learner { get; set; }

        public DbSet<Audit> Audit { get; set; }

        public DbSet<Allocate> Allocate { get; set; }

    }
}