using _14_MVVMToolkit2.Models;

namespace _14_MVVMToolkit2.Repositories {
    public interface IUserRepository {
        User Login(string username, string password);
    }
}