using RbPrinters.Api.Contracts.Models.Entity;
using RbPrinters.Api.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RbPrinters.Api.BLL.Extensions
{
    public static class UserExtension
    {
        /// <summary>
        /// return user by mobile number as username 
        /// </summary>
        /// <param name="userRepository"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static User GetUserByUserName(this IBaseRepository<User> userRepository, string userName)
        {
            var user = userRepository.All.FirstOrDefault(x => x.Mobile == userName);
            return user;
        }
    }
}
