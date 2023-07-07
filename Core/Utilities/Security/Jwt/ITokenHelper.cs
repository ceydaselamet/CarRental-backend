using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Core.Entities.Concrete;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims);
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
