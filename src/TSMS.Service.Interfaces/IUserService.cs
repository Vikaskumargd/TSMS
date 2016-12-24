using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSMS.ViewModels;

namespace TSMS.Service.Interfaces
{
    public interface IUserService 
    {
        Task<IdentityResult> CreateUser(CreateUserViewModel user);

    }
}
