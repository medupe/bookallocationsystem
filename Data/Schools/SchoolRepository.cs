using System.Collections.Generic;
using System.Linq;
using Bookallocationsystem.Data;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNet.Identity;
namespace bookallocationsystem.Data.Schools
{
    public class SchoolRepository : ISchoolRepository
    {
        public IdentityAppContext _db { get; }
        public SchoolRepository(IdentityAppContext db)
        {
            _db = db;

        }




        public async void AddSchool(School school)
        {
    

            School _std = new School();
            _std.SchoolName = school.SchoolName;
            _std.SchoolAddress = school.SchoolAddress;
            _std.SchoolNr = school.SchoolNr;
            _std.Email = school.Email;
            _std.ContactPerson = school.ContactPerson;
            _std.CellNumber = school.CellNumber;
            _std.Province = school.Province;
            _std.Region = school.Region;

          await   _db.AddAsync(school);

        }

        public void deleteSchool(int id)
        {
            throw new System.NotImplementedException();
        }

        public School findSchoolWithId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<School> schoolList()
        {
            return _db.School.ToList();
        }

        public void updateSchool(School school)
        {
            throw new System.NotImplementedException();
        }

        public int saveChanges()
        {
           return _db.SaveChanges();
        }
    }
}