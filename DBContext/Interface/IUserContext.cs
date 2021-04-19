using System.Threading.Tasks;

namespace Taleo.DBContext
{
    public interface IUserContext{
       Task<dynamic> GetAllUsers();
       Task<dynamic> GetAllUserGroups();
    }
}
