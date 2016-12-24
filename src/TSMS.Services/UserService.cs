using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TSMS.Entities;
using TSMS.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using TSMS.ViewModels;
using Microsoft.Extensions.Options;

namespace TSMS.Services
{
    public class UserService :IUserService
    {
        private readonly AppSettings _settings;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager, IOptions<AppSettings> settings)
        {
            _userManager = userManager;
            _settings = settings.Value;


        }

        public async Task<IdentityResult> CreateUser(CreateUserViewModel user)
        {
            ApplicationUser newUser = new ApplicationUser
            {
                Address = user.Address,
                Created = DateTime.Today,
                Modified = DateTime.Today,
                IsActive = true,
                Email = user.EmailAddress,
                PhoneNumber = user.PhoneNumber,
                Note = user.Note,
                Name = user.EmailAddress,
                UserName = user.PhoneNumber,
                PricingId = _settings.TSMS_PricingId

            };

           return await _userManager.CreateAsync(newUser);
        }
    }
}
