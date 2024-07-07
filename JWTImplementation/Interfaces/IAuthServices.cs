using JWTImplementation.Models;
using JWTImplementation.RequestModel;

namespace JWTImplementation.Interfaces
{
    public interface IAuthServices
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
    }
}
