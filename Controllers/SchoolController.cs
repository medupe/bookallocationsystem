using System.Threading.Tasks;
using bookallocationsystem.Data.Schools;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolRepository _schoolRepository;

        public SchoolController(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }

        public IActionResult Index()
        {
            var list = _schoolRepository.schoolList();
            SchoolViewIndex viewList = new SchoolViewIndex() { };

            foreach (var item in list)
            {
                viewList.schoolList.Add(item);
            }
            return View(viewList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(SchoolViewModelCreate schoolCreate)
        {
            if (ModelState.IsValid)
            {

                School _std = new School();
                _std.SchoolName = schoolCreate.SchoolName;
                _std.SchoolAddress = schoolCreate.SchoolAddress;
                _std.SchoolNr = schoolCreate.SchoolNr;
                _std.Email = schoolCreate.Email;
                _std.ContactPerson = schoolCreate.ContactPerson;
                _std.CellNumber = schoolCreate.CellNumber;
                _std.Province = schoolCreate.Province;
                _std.Region = schoolCreate.Region;
                _schoolRepository.AddSchool(_std);
                _schoolRepository.saveChanges();

                return RedirectToAction("Index", "School");

            }

            return View();
        }

    }
}