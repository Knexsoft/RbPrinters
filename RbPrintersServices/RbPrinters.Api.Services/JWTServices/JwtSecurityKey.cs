using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace RbPrinters.Api.Services.JWTServices
{
    public class JwtSecurityKey
    {
        public static SymmetricSecurityKey Create(string Secret)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Secret));
        }
    }
}
