using System.Collections.Generic;
using System.Data;
using System.Security.Claims;
using System.Threading.Tasks;
using bookallocationsystem.Models.Books;
using bookallocationsystem.Models.Subjects;

namespace bookallocationsystem.Data.Books
{
    public interface IBookRepository
    {
        Task<List<Book>> BookList();
        List<Subject> SubjectList();
        Task<Book> FindBookWithId(int id);
        void UpdateSchool(Book book);
        Task AddBook(BookViewCreate bookCreate, string email);
        void DeleteSchool(int id);
        Task<Subject> FindSubjectByName(string subjectName);
        Task BulkUploadBooks(DataTable book,string email);
        int SaveChanges();
    }
}