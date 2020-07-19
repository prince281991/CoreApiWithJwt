using JwtTokenAuthentication.Core.Api.Models;
using System.Threading.Tasks;


namespace JwtTokenAuthentication.Core.Api.Repositories
{
    public interface IRoleService
    {
        Task<string> AddRoleAsync(Roles model);
    }
}
