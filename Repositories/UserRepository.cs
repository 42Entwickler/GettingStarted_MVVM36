using _14_MVVMToolkit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace _14_MVVMToolkit2.Repositories;
public class UserRepository : IUserRepository {
    // Dummy repository
    public User Login(string username, string password) => new User() { Username = "DevDave", Id = 1 };
}

