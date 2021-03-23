using System.Data;
using System.IO;
using System.Threading.Tasks;
using bookallocationsystem.Data.Learners;
using bookallocationsystem.Data.Schools;
using bookallocationsystem.Models.Learners;
using ClosedXML.Excel;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Controllers
{
    [Authorize]
    public class LearnerController : Controller
    {
        private readonly ILearnerRepository _learnerRepository;
        private readonly ISchoolRepository _schoolRepository;
        public LearnerController(ILearnerRepository learnerRepository, ISchoolRepository schoolRepository)
        {
            _learnerRepository = learnerRepository;
            _schoolRepository = schoolRepository;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _learnerRepository.LearnerList();
            LearnerViewIndex viewList = new LearnerViewIndex() { };

            foreach (var item in list)
            {
                viewList.LearnerList.Add(item);
            }
            return View(viewList);
        }
        /*    public LearnerViewCreate GetInitData()
            {
               // List<School> _SchoolList = new List<School>();
            //    List<Subject> _SubjectList = new List<Subject>();

              //  _SchoolList = _schoolRepository.schoolList();
              //  _SubjectList = _bookRepository.SubjectList();


                BookViewCreate _viewCreate = new BookViewCreate();
                _viewCreate.SchoolList = _SchoolList;
                _viewCreate.SubjectList = _SubjectList;

                return _viewCreate;

            }*/
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]

        public async Task<IActionResult> Create(LearnerViewCreate learnerViewCreate)
        {
            if (ModelState.IsValid)
            {

                var a = User.Identity.GetUserId();

                await _learnerRepository.AddLearner(learnerViewCreate, User.Identity.Name.ToString());

                _learnerRepository.SaveChanges();

                return RedirectToAction("Index", "Learner");

            }
            ModelState.AddModelError(string.Empty, "Username or password is invalidt");
            return View();


        }
        [HttpGet]
        public IActionResult Upload()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Upload(LearnerViewUpload file)
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
                await _learnerRepository.BulkUploadLearner(dataTable, User.Identity.Name.ToString());
                _learnerRepository.SaveChanges();

            }

            return View();


        }

    }
}