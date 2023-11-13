using BackendApp.IRepo;
using BackendApp.Models;
using System.Security.Cryptography;

namespace BackendApp.Services
{
    public interface IUserService
    {
        void CreatePublicUser(PublicUser publicUser);
        bool SaveChanges();
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void UpdateUser(User user);
        Task<PublicUser> GetPublicUserById(int id);
        IEnumerable<PublicUser> GetAllPublicUsers();
        void DeletePublicUser(PublicUser user);
    }
    public class UserService: IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public void CreatePublicUser(PublicUser publicUser)
        {
            _userRepo.CreatePublicUser(publicUser);
            _userRepo.SaveChanges();
        }

        public void DeletePublicUser(PublicUser user)
        {
            _userRepo.DeletePublicUser(user);
            _userRepo.SaveChanges();
        }

        public IEnumerable<PublicUser> GetAllPublicUsers()
        {
            return _userRepo.GetAllPublicUsers();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<PublicUser> GetPublicUserById(int id)
        {
            return await _userRepo.GetPublicUserById(id);
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return _userRepo.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            
        }

        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }

    
}
