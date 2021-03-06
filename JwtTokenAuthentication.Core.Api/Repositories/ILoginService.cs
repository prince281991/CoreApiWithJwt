﻿using JwtTokenAuthentication.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtTokenAuthentication.Core.Api.Repositories
{
    public interface ILoginService
    {
        Task<AuthenticationResponseModel> GetTokenAsync(AuthenticationRequestModel model);
    }
}
