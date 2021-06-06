using System.Collections.Generic;
using System.Threading.Tasks;
using bookallocationsystem.Models.Allocation;
using bookallocationsystem.Models.Learners;

namespace bookallocationsystem.Data.Allocation
{
    public interface IAllocateRepository
    {
        Task<List<Allocate>> AllocateList();

        Allocate FindAllocateWithId(int id);
        void UpdateAllocate(Learner book);
        Task AddAllocate(AllocateViewCreate LearnerCreate, string email,int bookId);
        void DeleteAllocate(int id);

      
        int SaveChanges();
    }
}