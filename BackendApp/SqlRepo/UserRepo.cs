using BackendApp.Data;
using BackendApp.IRepo;
using BackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.SqlRepo
{
    public class UserRepo : IUserRepo
    {
        private readonly ShopContext _context;

        public UserRepo(ShopContext context)
        {
            _context = context;
        }
        public void CreatePublicUser(PublicUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.PublicUsers.Add(user);
        }

        public void DeletePublicUser(PublicUser user)
        {
            if (user == null)
            {
                throw new ArgumentException($"This user {user} not found");
            }

            _context.PublicUsers.Remove(user);
        }

        public IEnumerable<PublicUser> GetAllPublicUsers()
        {
            return _context.PublicUsers.ToList();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public async Task<PublicUser> GetPublicUserById(int id)
        {
            return await _context.PublicUsers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser(User user)
        {
            
        }
    }
}
