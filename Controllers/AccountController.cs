
using System.Collections.Generic;
using System.Threading.Tasks;
using bookallocationsystem.Data.Schools;
using bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Data.Accounts;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookallocationsystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAppAccountRepository _appAccountRepository;
        private readonly ISchoolRepository _schoolRepository;
        public AccountController(IAppAccountRepository appAccountRepository, ISchoolRepository schoolRepository)
        {
            _appAccountRepository = appAccountRepository;
            _schoolRepository = schoolRepository;
        }
        public Register GetRegisterDefaultClasses(){
           List<School> _SchoolList = new List<School>();

            _SchoolList = _schoolRepository.schoolList();


            Register _reg = new Register();
            _reg.SchoolList = _SchoolList;

            return _reg;

        }

        public IActionResult Register()
        {


            return View(GetRegisterDefaultClasses());
        }
        public async Task<IActionResult> Logout()
        {
            await _appAccountRepository.logout();

            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            var list = _appAccountRepository.userList();
            UserIndex viewList = new UserIndex() { };

            foreach (var item in list)
            {
                viewList.userList.Add(item);
            }
            return View(viewList);
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (ModelState.IsValid)
            {
                var user = register;
                var results = await _appAccountRepository.register(user);
                if (results.Succeeded)
                {
                     return RedirectToAction("Index", "Account");
                }
                     ModelState.AddModelError(string.Empty, "Username or password is invalidt");
            }
            return View(GetRegisterDefaultClasses());


        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = await _appAccountRepository.login(login);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }

                ModelState.AddModelError(string.Empty, "Username or password is invalidt");

            }
            return View();
        }

    }
}