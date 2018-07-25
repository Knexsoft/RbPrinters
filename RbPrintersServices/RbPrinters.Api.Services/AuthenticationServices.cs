using RbPrinters.Api.Contracts.Models.Entity;
using RbPrinters.Api.Interfaces.Repositories;
using RbPrinters.Api.Interfaces.Services;
using RbPrinters.Api.Services.Abstracts;
using RbPrinters.Api.Services.JWTServices;
using RbPrinters.Api.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace RbPrinters.Api.Services
{
    public class AuthenticationServices : IAuthenticationServices
    {
        #region Variables
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<UserRole> _roleRepository;
        private readonly IBaseRepository<UserRole> _userRoleRepository;
        private readonly IEncryptionServices _encryptionService;
        #endregion

        public AuthenticationServices(IBaseRepository<User> userRepository, IBaseRepository<UserRole> roleRepository,
        IBaseRepository<UserRole> userRoleRepository, IEncryptionServices encryptionService)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
            _encryptionService = encryptionService;
        }

        #region IAuthenticationService Implementation

        public User ValidateUser(string username, string password)
        {
            var user = GetUserByUserName(username);
            if (user != null && isUserValid(user, password))
            {
                //var userRoles = GetUserRoles(user.Email);
                //AuthCtx.User = user;
                //string fullName = user.FirstName + " " + user.LastName;
                //var identity = new GenericIdentity(fullName);
                //AuthCtx.Principal = new GenericPrincipal(
                //identity,
                //userRoles.Select(x => x.Name).ToArray());
                return user;
            }

            return null;
        }

        public User CreateUser(string email, string password)
        {
            var existingUser = GetUserByUserName(email);

            if (existingUser != null)
            {
                throw new Exception("Username is already in use");
            }

            var passwordSalt = _encryptionService.CreateSalt();
            Guid Id = Guid.NewGuid();
            var user = new User();
            //{
            //    Email = email,
            //    Salt = passwordSalt,
            //    Password = _encryptionService.EncryptPassword(password, passwordSalt),
            //    AuthID = Id,
            //    ApprovedBy = Id,
            //    VerifiedEmail = false,
            //    VerifiedPhone = false,
            //    IsActive = false,
            //    IsDeleted = false,
            //    ModifiedOn = DateTime.Now,
            //    CreatedOn = DateTime.Now
            //};

            _userRepository.Add(user);

            //_unitOfWork.Commit();

            //if (roles != null || roles.Length > 0)
            //{
            //    foreach (var role in roles)
            //    {
            //        addUserToRole(user, role);
            //    }
            //}

            //_unitOfWork.Commit();

            return user;
        }

        public User GetUser(Guid userId)
        {
            return _userRepository.Get(userId);
        }

        public JwtToken GetToken(User user)
        {
            var token = new JwtTokenBuilder()
                                    .AddSecurityKey(JwtSecurityKey.Create("fiver-secret-key"))
                                    .AddSubject(string.Format("{0}", user.Mobile))
                                    .AddIssuer("Fiver.Security.Bearer")
                                    .AddAudience("Fiver.Security.Bearer")
                                    .AddClaim("MembershipId", "111")
                                    .AddExpiry(1)
                                    .Build();
            return token;
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Check password 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool isPasswordValid(User user, string password)
        {
            //return string.Equals(_encryptionService.EncryptPassword(password, user.Salt), user.Password);
            return string.Equals(user.HashPassword, password);
        }

        /// <summary>
        /// Check user password with IsDeleted and IsActive
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool isUserValid(User user, string password)
        {
            if (isPasswordValid(user, password))
                return !user.IsDeleted && user.IsActive;
            return false;
        }

        private User GetUserByUserName(string userName)
        {
            return _userRepository.All.FirstOrDefault(x => x.Mobile == userName);
        }

        public List<UserRole> GetUserRoles(string username)
        {
            throw new NotImplementedException();
        }
        #endregion




    }
}
