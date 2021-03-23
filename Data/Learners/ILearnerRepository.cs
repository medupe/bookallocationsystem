using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using bookallocationsystem.Models.Learners;

namespace bookallocationsystem.Data.Learners
{
    public interface ILearnerRepository
    {
        Task<List<Learner>> LearnerList();

        Learner FindLearnerWithId(int id);
        void UpdateLearner(Learner book);
        Task AddLearner(LearnerViewCreate LearnerCreate, string email);
        void DeleteLearner(int id);

        Task BulkUploadLearner(DataTable LearnerData, string email);
        int SaveChanges();
    }
}