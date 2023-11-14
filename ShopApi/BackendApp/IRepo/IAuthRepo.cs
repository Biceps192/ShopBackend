using BackendApp.Models;
using System.Security.Cryptography;

namespace BackendApp.IRepo
{
    public interface IAuthRepo
    {
        bool SaveChanges();
        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        User GetUserByEmail(string email);
        void CreateUser(User user);
    }
}
