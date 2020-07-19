using JwtTokenAuthentication.Core.Api.Contasnts;
using JwtTokenAuthentication.Core.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace JwtTokenAuthentication.Core.Api.Repositories
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<string> RegisterAsync(User model)
        {
            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName=model.Username,
                FirstName=model.FirstName,
                LastName=model.LastName
            };
            var userWithSameEmail = _userManager.FindByEmailAsync(model.Email);
            if (userWithSameEmail == null)
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, DefaultUserDetails.DefaultRole.ToString());
                }
                return $"User Registered with username {user.UserName}";
            }
            else
            {
                return $"Email {user.Email } is already registered.";
            }
        }
    }
}
