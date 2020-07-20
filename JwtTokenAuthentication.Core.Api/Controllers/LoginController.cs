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
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost("token")]
        public async Task<IActionResult> GetTokenAsync(AuthenticationRequestModel model)
        {
            var result = await _loginService.GetTokenAsync(model);
            return Ok(result);
        }
    }
}
