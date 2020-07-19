using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static JwtTokenAuthentication.Core.Api.Contasnts.ApplicationRoles;

namespace JwtTokenAuthentication.Core.Api.Contasnts
{
    public class DefaultUserDetails
    {
        public const string DefaultUserName = "prince";
        public const string DefaultEmail = "princeprasad.1991@gmail.com";
        public const string DefaultPassword = "Aa@1234567";
        public const Roles DefaultRole = Roles.User;
    }
}
