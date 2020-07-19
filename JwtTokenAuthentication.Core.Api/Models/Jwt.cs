using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtTokenAuthentication.Core.Api.Models
{
    public class Jwt
    {
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }
        public string Issuer { get; set; }
        public string Key { get; set; }
    }
}
