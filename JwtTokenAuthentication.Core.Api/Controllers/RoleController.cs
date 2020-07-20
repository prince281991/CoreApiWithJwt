using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwtTokenAuthentication.Core.Api.Models;
using JwtTokenAuthentication.Core.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenAuthentication.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpPost("addrole")]
        public async Task<IActionResult> AddRoleAsync(Roles model)
        {
            var result = await _roleService.AddRoleAsync(model);
            return Ok(result);
        }
    }
}
