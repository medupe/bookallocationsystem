using System.Collections.Generic;
using System.Threading.Tasks;
using bookallocationsystem.Models.Allocation;
using bookallocationsystem.Models.Learners;
using Bookallocationsystem.Data;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace bookallocationsystem.Data.Allocation
{
    public class AllocateRepository : IAllocateRepository
    {
        public readonly IdentityAppContext _db;
        private readonly UserManager<AppUser> _userManager;
        public AllocateRepository(IdentityAppContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task AddAllocate(AllocateViewCreate allocateCreate, string email,int bookId)
        {
            var userInformation = await _userManager.FindByNameAsync(email);

            var _school = await _db.School.FindAsync(1);
            var _learner = await _db.Learner.FindAsync(allocateCreate.LearnerId);
            var _book = await _db.Book.FindAsync(bookId);

            Allocate _allocate = new Allocate();
            _allocate.AllocationCondition = allocateCreate.AllocationCondition;
            _allocate.Book = _book;

            _allocate.Learner = _learner;
            _allocate.School = _school;



            _allocate.AddedBy = userInformation;

            await _db.AddAsync(_allocate);
        }

        public async Task<List<Allocate>> AllocateList()
        {
            var _data = _db.Allocate;
            return await _data.Include(x => x.Book).Include(p => p.Learner).ToListAsync();
        }

        public void DeleteAllocate(int id)
        {
            throw new System.NotImplementedException();
        }

        public Allocate FindAllocateWithId(int id)
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void UpdateAllocate(Learner book)
        {
            throw new System.NotImplementedException();
        }
    }
}