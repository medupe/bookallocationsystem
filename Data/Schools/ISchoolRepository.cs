using System.Collections.Generic;
using Bookallocationsystem.Models.Schools;

namespace bookallocationsystem.Data.Schools
{
    public interface ISchoolRepository
    {
         List<School> schoolList();
          School findSchoolWithId(int id);
          void updateSchool(School school);
           void AddSchool(School school);
          void deleteSchool(int id);
          int saveChanges();

    }
}