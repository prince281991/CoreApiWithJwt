using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtTokenAuthentication.Core.Api.Models
{
    public class AuthenticationRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
