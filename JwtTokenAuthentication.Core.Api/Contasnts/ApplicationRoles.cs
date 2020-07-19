using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtTokenAuthentication.Core.Api.Contasnts
{
    public class ApplicationRoles
    {
        public enum Roles
        {
            Administrator,
            Moderator,
            User
        }
    }
}
