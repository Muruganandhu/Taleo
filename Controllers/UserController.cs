using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Taleo.Repositories.Interface;

namespace Taleo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IUserRepository _userRepo;
        public UserController(IUserRepository userRepo)
        {
            this._userRepo = userRepo;
        }

        [HttpGet]
        [Route("GETUsers")]
        public async Task<dynamic> GetallUsers()
        {
            return await this._userRepo.GetAllUsers();
        }
        [HttpGet]
        [Route("GETUserGroups")]
        public async Task<dynamic> GetallUserGroups()
        {
            return await this._userRepo.GetAllUserGroups();
        }
    }
}
