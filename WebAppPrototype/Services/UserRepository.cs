using WebAppPrototype.Helpers;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Services
{
    public class UserRepository : IUserRepository {
        string jsonFileName = @"JsonData\JsonUsers.json";
        public List<User> GetAllUsers() {
            return JsonFileReader.ReadJsonUsers(jsonFileName);
        }

        //Add user method
    }
}
