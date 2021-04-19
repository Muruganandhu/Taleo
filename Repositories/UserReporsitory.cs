using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Taleo.DBContext;
using Taleo.Repositories.Interface;

namespace Taleo.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IUserContext _userDB;
        public UserRepository(IUserContext userDB)
        {
            this._userDB = userDB;
        }
         public async Task<dynamic> GetAllUsers()
        {
            return await this._userDB.GetAllUsers();
        }
         public async Task<dynamic> GetAllUserGroups()
        {
            return await this._userDB.GetAllUserGroups();
        }
    }
}
