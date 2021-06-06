using System.Collections.Generic;
using System.Threading.Tasks;
using bookallocationsystem.Models.Allocation;
using bookallocationsystem.Models.Audits;

namespace bookallocationsystem.Data.Audits
{
    public interface IAuditRepository
    {
        void AuditBook(AuditViewCreate auditBook, string email);
        Task<List<Allocate>>  AuditData(int id);
    }
}