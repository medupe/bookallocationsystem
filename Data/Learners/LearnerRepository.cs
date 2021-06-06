using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using bookallocationsystem.Models.Learners;
using Bookallocationsystem.Data;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace bookallocationsystem.Data.Learners
{
    public class LearnerRepository : ILearnerRepository
    {
        public readonly IdentityAppContext _db;
        private readonly UserManager<AppUser> _userManager;
        public LearnerRepository(IdentityAppContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task AddLearner(LearnerViewCreate LearnerCreate, string email)
        {
            var userInformation = await _userManager.FindByNameAsync(email);

            var _school = await _db.School.FindAsync(LearnerCreate.SchoolId);

            Learner _learner = new Learner();
            _learner.FirstName = LearnerCreate.FirstName;
            _learner.LastName = LearnerCreate.LastName;

            _learner.Grade = LearnerCreate.Grade;
            _learner.GradeClass = LearnerCreate.GradeClass;
            _learner.IdentityNumber = LearnerCreate.IdentityNumber;
            _learner.school = _school;

            _learner.AddedBy = userInformation;

            await _db.AddAsync(_learner);
        }

        public async Task<List<Learner>> LearnerList()
        {
            var _data = _db.Learner;
            return await _data.Include(p => p.school).ToListAsync();
        }

        public async Task BulkUploadLearner(DataTable LearnerData, string email)
        {
            List<Learner> _learner = new List<Learner>();
            foreach (DataRow item in LearnerData.Rows)
            {
                _learner.Add(new Learner
                {
                    FirstName = item[0].ToString(),
                    LastName = item[1].ToString(),
                    Grade = item[2].ToString(),
                    GradeClass = item[3].ToString(),
                    IdentityNumber = item[4].ToString(),
                    AddedBy = await _userManager.FindByNameAsync(email),

                    school = await _db.School.FindAsync(1),

                });
            }
            await _db.AddRangeAsync(_learner);
        }

        public void DeleteLearner(int id)
        {
            throw new System.NotImplementedException();
        }

        public Learner FindLearnerWithId(int id)
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void UpdateLearner(Learner book)
        {
            throw new System.NotImplementedException();
        }
    }
}