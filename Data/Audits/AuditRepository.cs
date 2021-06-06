using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookallocationsystem.Models.Allocation;
using bookallocationsystem.Models.Audits;
using Bookallocationsystem.Data;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace bookallocationsystem.Data.Audits
{
    public class AuditRepository : IAuditRepository
    {
        public readonly IdentityAppContext _db;
        private readonly UserManager<AppUser> _userManager;
        public AuditRepository(IdentityAppContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async void AuditBook(AuditViewCreate auditBook, string email)
        {
            var _userInformation = await _userManager.FindByNameAsync(email);
            var _allocate   = await _db.Allocate.FindAsync(auditBook.AllocateId);
            var _book = await _db.Book.FindAsync(_allocate.Book.Id);
            Audit _audit = new Audit(){};
            _audit.Allocate=_allocate;
            _audit.AuditQuater=auditBook.AuditQuater;
            _audit.AuditBy=_userInformation;
       //     _audit.
            
          await   _db.Audit.AddAsync(_audit);
          _book.Condition = auditBook.AuditCondition;

        }
        
        public   Allocate   AuditData(int id)
        {


            var _data = _db.Allocate.FirstOrDefault(x=>x.Id==id);
            return   _data.Include(x => x.Learner).Include(x=>x.Book).FirstOrDefault;
        }
    }
}