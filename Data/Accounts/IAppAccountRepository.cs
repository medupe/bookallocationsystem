using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Identity;

namespace Bookallocationsystem.Data.Accounts
{
    public interface IAppAccountRepository
    {
        Task<SignInResult> login(Login login);
        Task<IdentityResult> register(Register register);
        Task logout();
        List<AppUser> userList();
        void resetPassword(AppUser user);
    }
}
