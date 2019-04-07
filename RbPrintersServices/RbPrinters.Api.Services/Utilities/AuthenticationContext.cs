using RbPrinters.Api.Contracts.Models.Entity;
using System.Security.Principal;

namespace RbPrinters.Api.Services.Utilities
{
    public class AuthenticationContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }
    }
}
