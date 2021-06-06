using System.Linq;
using System.Threading.Tasks;
using bookallocationsystem.Data.Allocation;
using bookallocationsystem.Data.Books;
using bookallocationsystem.Data.Learners;
using bookallocationsystem.Data.Schools;
using bookallocationsystem.Models.Allocation;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bookallocationsystem.Controllers
{
    [Authorize]
    public class AllocateController : Controller
    {
        private readonly ILearnerRepository _learnerRepository;
        private readonly ISchoolRepository _schoolRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IAllocateRepository _allocateRepository;
        public AllocateController(IAllocateRepository  allocateRepository ,IBookRepository bookRepository, ILearnerRepository learnerRepository, ISchoolRepository schoolRepository)
        {
            _learnerRepository = learnerRepository;
            _schoolRepository = schoolRepository;
            _bookRepository=bookRepository;
            _allocateRepository=allocateRepository;
        }
        [HttpGet]
      //  [Route("/{id}")]
        public async  Task<IActionResult> Create(int id)
        {
            return View(await  getInitData(id));

        }
         [HttpPost]
        public async Task<IActionResult> Create(AllocateViewCreate allocateViewCreate,int id)
        {
            ModelState.Remove("allocateViewCreate.Book");
                ModelState.Remove("allocateViewCreate.LearnerList");
                        ModelState.Remove("allocateViewCreate.BookId");
                         var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {

                var a = User.Identity.GetUserId();

                await _allocateRepository.AddAllocate(allocateViewCreate, User.Identity.Name.ToString(),id);

                _allocateRepository.SaveChanges();

                return RedirectToAction("Index", "Book");

            }
            //   ModelState.AddModelError(string.Empty, "Username or password is invalidt");
            return View( await getInitData(id));


        }
        public async  Task<AllocateViewCreate>  getInitData(int id){
          var _book=await   _bookRepository.FindBookWithId(id);
            AllocateViewCreate _allocateCreate = new AllocateViewCreate();
            _allocateCreate.Book=_book;
            _allocateCreate.LearnerList=await _learnerRepository.LearnerList();
            return _allocateCreate;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var _list = await _allocateRepository.AllocateList();
            AllocateViewIndex _viewList = new AllocateViewIndex() { };

            foreach (var item in _list)
            {
                _viewList.AllocationList.Add(item);
            }
            return View(_viewList);
        }
    }
}