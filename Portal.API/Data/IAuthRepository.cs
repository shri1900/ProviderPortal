using System.Threading.Tasks;
using Portal.API.Models;

namespace Portal.API.Data
{
    public interface IAuthRepository
    {
         Task<User> RegisterAsync(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExistsAsync(string username);
    }
}