using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookallocationsystem.Models.AppUsers;
using Bookallocationsystem.Models.Schools;
using Microsoft.AspNetCore.Identity;

namespace Bookallocationsystem.Data.Accounts
{
    public class AppAccountRepository : IAppAccountRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public IdentityAppContext _db { get; }
        public AppAccountRepository(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IdentityAppContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public async Task<SignInResult> login(Login login)
        {
            return await _signInManager.PasswordSignInAsync(login.Username, login.Password, login.RememberPassword, false);

        }

        public async Task logout()
        {
            await _signInManager.SignOutAsync();
        }

        public Task<IdentityResult> register(Register register)
        {
            var school = _db.School.Find(register.School.Id);
            AppUser _newUser = new AppUser();
            _newUser.UserName = register.Email;
            _newUser.Email = register.Email;
            _newUser.FirstName = register.FirstName;
            _newUser.LastName = register.LastName;
            _newUser.School = school;
            return _userManager.CreateAsync(_newUser, register.Password);

        }
        public List<AppUser> userList()
        {


            return _db.Users.ToList();
        }
        

        public void resetPassword(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
