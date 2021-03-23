
using System.Threading.Tasks;
using Bookallocationsystem.Data.Accounts;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookallocationsystem.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IAppAccountRepository _appAccountRepository;

        public DashboardController(IAppAccountRepository appAccountRepository)
        {
          _appAccountRepository = appAccountRepository;
        }

        public async  Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }

        public async Task<IActionResult> submitUser(Register register)
        {
            var user = register;
            var results = await _appAccountRepository.register(user);
            return RedirectToPage("/Register");


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
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Username or password is invalidt");

            }
            return View();
        } 

    }
}