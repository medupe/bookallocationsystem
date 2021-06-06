using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using bookallocationsystem.Data.Books;
using bookallocationsystem.Data.Schools;
using bookallocationsystem.Models.Books;
using bookallocationsystem.Models.Subjects;
using Bookallocationsystem.Models.Schools;
using ClosedXML.Excel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ISchoolRepository _schoolRepository;
        public BookController(IBookRepository bookRepository, ISchoolRepository schoolRepository)
        {
            _bookRepository = bookRepository;
            _schoolRepository = schoolRepository;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _bookRepository.BookList();
            BookViewIndex viewList = new BookViewIndex() { };

            foreach (var item in list)
            {
                viewList.BookList.Add(item);
            }
            return View(viewList);
        }
        public BookViewCreate GetInitData()
        {
            List<School> _SchoolList = new List<School>();
            List<Subject> _SubjectList = new List<Subject>();

            _SchoolList = _schoolRepository.schoolList();
            _SubjectList = _bookRepository.SubjectList();


            BookViewCreate _viewCreate = new BookViewCreate();
            _viewCreate.SchoolList = _SchoolList;
            _viewCreate.SubjectList = _SubjectList;

            return _viewCreate;

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(GetInitData());

        }
        [HttpPost]

        public async Task<IActionResult> Create(BookViewCreate bookViewCreate)
        {
            if (ModelState.IsValid)
            {

                var a = User.Identity.GetUserId();

                await _bookRepository.AddBook(bookViewCreate, User.Identity.Name.ToString());

                _bookRepository.SaveChanges();

                return RedirectToAction("Index", "Book");

            }
            //   ModelState.AddModelError(string.Empty, "Username or password is invalidt");
            return View(GetInitData());


        }
        [HttpGet]
        public IActionResult Upload()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Upload(BookViewUpload file)
        {

            var filePath = Path.GetTempFileName();
            var fileNameUpload = Path.GetFileName(file.FileUpload.FileName);


            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName + "\\uploads";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = Path.Combine(path, fileNameUpload);
            using (var stream = System.IO.File.Create(fileName))
            {
                await file.FileUpload.CopyToAsync(stream);
            }
            using (var workBook = new XLWorkbook(fileName))
            {
                var workSheet = workBook.Worksheet(1);

                DataTable dataTable = workSheet.RangeUsed().AsTable().AsNativeDataTable();
                await _bookRepository.BulkUploadBooks(dataTable, User.Identity.Name.ToString());
                _bookRepository.SaveChanges();
          
            }

               return RedirectToAction("Index", "Book");


        }

    }
}