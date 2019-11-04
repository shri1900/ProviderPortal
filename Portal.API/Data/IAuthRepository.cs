using System.Threading.Tasks;
using Portal.Api.Models;

namespace Portal.Api.Data
{
    public interface IAuthRepository
    {
         Task<User> RegisterAsync(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExistsAsync(string username);
    }
}