using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Common
{
    public class SeedIdentityData
    {
        private readonly UserManager<IdentityUser> _userManager;

        public SeedIdentityData(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task SeedUsers()
        {
            var user = await _userManager.FindByNameAsync("admin@myapp.com");
            if (user == null)
            {

                await _userManager.CreateAsync(new IdentityUser
                {
                    Email = "admin@myapp.com",
                    UserName = "admin@myapp.com",
                }, "123@Abc");
            }
        }
    }
}
