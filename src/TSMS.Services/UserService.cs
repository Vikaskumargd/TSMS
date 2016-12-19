using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using TSMS.Entities;
using TSMS.Service.Interfaces;
using Microsoft.Extensions.Configuration;

namespace TSMS.Services
{
    public class UserService :IUserService
    {
        private readonly IConfigurationRoot _configuration;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager, IConfigurationRoot configuration)
        {
            _userManager = userManager;
            _configuration = configuration;


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
                PricingId = Convert.ToInt64(_configuration["TSMS-PricingId"])

            };

           return await _userManager.CreateAsync(newUser);
        }
    }
}
