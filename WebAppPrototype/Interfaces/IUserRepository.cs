using WebAppPrototype.Models;
namespace WebAppPrototype.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        void AddUser(User ur);
    }
}
