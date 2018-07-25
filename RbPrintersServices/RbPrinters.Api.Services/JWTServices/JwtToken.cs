using System;
using System.IdentityModel.Tokens.Jwt;

namespace RbPrinters.Api.Services.JWTServices
{
    public sealed class JwtToken
    {
        private JwtSecurityToken token;

        internal JwtToken(JwtSecurityToken token)
        {
            this.token = token;
        }

        public DateTime ValidTo => token.ValidTo;
        public string token_access => new JwtSecurityTokenHandler().WriteToken(this.token);
        public string user_name => token.Subject;
    }
}
