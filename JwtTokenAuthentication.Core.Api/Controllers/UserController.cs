using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JwtTokenAuthentication.Core.Api.Repositories;
using JwtTokenAuthentication.Core.Api.Models;

namespace JwtTokenAuthentication.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(User model)
        {
            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }
    }
}
