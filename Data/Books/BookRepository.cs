using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using bookallocationsystem.Models.Books;
using bookallocationsystem.Models.Subjects;
using Bookallocationsystem.Data;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace bookallocationsystem.Data.Books
{

    public class BookRepository : IBookRepository
    {
        public readonly IdentityAppContext _db;
        private readonly UserManager<AppUser> _userManager;
        public BookRepository(IdentityAppContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task AddBook(BookViewCreate bookCreate, string email)
        {
            var userInformation = await _userManager.FindByNameAsync(email);
            var _subject = await _db.Subject.FindAsync(bookCreate.SubjectId);
            var _school = await _db.School.FindAsync(bookCreate.SchoolId);


            Book _book = new Book();
            _book.Title = bookCreate.Title;
            _book.Code = bookCreate.Code;

            _book.Grade = bookCreate.Grade;
            _book.GradeClass = bookCreate.GradeClass;
            _book.ISBN = bookCreate.ISBN;
            _book.School = _school;
            _book.Subject = _subject;
            _book.AddedBy = userInformation;

            await _db.AddAsync(_book);

        }
        public async Task BulkUploadBooks(DataTable dataTable,string email)
        {
                List<Book> _book= new List<Book>();
                  foreach (DataRow item in dataTable.Rows)
                {
                   _book.Add(new Book{
                      Code=item[0].ToString(),
                      Title=item[1].ToString(),
                      ISBN=item[2].ToString(),
                      Grade=item[3].ToString(),
                      GradeClass=item[4].ToString(),
                      AddedBy= await _userManager.FindByNameAsync(email),
                      Subject=await FindSubjectByName(item[5].ToString()),
                      School= await _db.School.FindAsync(1),
               
                   });
                }
            await _db.AddRangeAsync(_book);
        }

        public async Task<List<Book>> BookList()
        {


            var _data = _db.Book;
            return await _data.Include(x => x.Subject).Include(p => p.School).ToListAsync();
        }

        public void DeleteSchool(int id)
        {
            throw new System.NotImplementedException();
        }

        public Book FindBookWithId(int id)
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void UpdateSchool(Book book)
        {
            throw new System.NotImplementedException();
        }

        public List<Subject> SubjectList()
        {
            return _db.Subject.ToList();
        }

        public async Task<Subject> FindSubjectByName(string subjectName)
        {
            return await _db.Subject.FirstOrDefaultAsync(x => x.Name == subjectName);
        }

    
    }
}