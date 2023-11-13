using BackendApp.Data;
using BackendApp.IRepo;
using BackendApp.Models;
using System.Security.Cryptography;

namespace BackendApp.SqlRepo
{
    public class AuthRepo : IAuthRepo
    {
        private readonly ShopContext _context;

        public AuthRepo(ShopContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            var publicUser = _context.PublicUsers.FirstOrDefault(x => x.Email == user.Email);

            if (publicUser != null && publicUser.Email == user.Email)
            {
                user.PublicUserId = publicUser.Id;
                _context.Users.Add(user);
            }
            else
            {
                PublicUser publicUser1 = new PublicUser
                {
                    Email = user.Email,
                    PhoneNumber = "",
                    LastName = "",
                    FirstName = ""
                };
                _context.PublicUsers.Add(publicUser1);
                SaveChanges();

                user.PublicUserId = publicUser1.Id;
                _context.Users.Add(user);
            }

        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
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
