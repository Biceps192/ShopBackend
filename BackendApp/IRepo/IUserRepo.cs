using BackendApp.Models;

namespace BackendApp.IRepo
{
    public interface IUserRepo
    {
        bool SaveChanges();
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        void UpdateUser(User user);
        Task<PublicUser> GetPublicUserById(int id);
        IEnumerable<PublicUser> GetAllPublicUsers();
        void CreatePublicUser(PublicUser user);
        void DeletePublicUser(PublicUser user);

    }
}
