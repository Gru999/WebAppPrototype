using WebAppPrototype.Models;
namespace WebAppPrototype.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUser(int userId);
        void AddUser(User user);
    }
}
