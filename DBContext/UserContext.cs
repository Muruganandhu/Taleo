using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Taleo.DBContext
{
    public class UserContext:IUserContext{
         private TaleoDBContext _dBContext;
        public UserContext(TaleoDBContext dBContext)
        {
            this._dBContext = dBContext;
        }
        public async Task<dynamic> GetAllUsers()
        {
            return await this._dBContext.Users.ToListAsync();
        }
         public async Task<dynamic> GetAllUserGroups()
        {
            return await this._dBContext.UserGroups.ToListAsync();
        }
    }
}
