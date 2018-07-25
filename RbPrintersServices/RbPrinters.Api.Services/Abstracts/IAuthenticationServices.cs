using RbPrinters.Api.Contracts.Models.Entity;
using RbPrinters.Api.Services.JWTServices;
using RbPrinters.Api.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Services.Abstracts
{
    public interface IAuthenticationServices
    {
        /// <summary>
        /// Validate User
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User ValidateUser(string username, string password);
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User CreateUser(string email, string password);
        /// <summary>
        /// Get all details of a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        User GetUser(Guid userId);
        /// <summary>
        /// Get User Roles
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        List<UserRole> GetUserRoles(string username);

        JwtToken GetToken(User user);
    }
}
