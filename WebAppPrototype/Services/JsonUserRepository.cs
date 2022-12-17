using System.Diagnostics.Metrics;
using WebAppPrototype.Helpers;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Services {
    public class JsonUserRepository : IUserRepository {
        string jsonFileName = @"JsonData\JsonUsers.json";
        public List<User> GetAllUsers() {
            return JsonFileReader.ReadJsonUsers(jsonFileName);
        }
        public User GetUser(int userId) {
            List<User> users = GetAllUsers();
            foreach (var usr in users) {
                if (usr.UserId == userId) {
                    return usr;
                }
            }
            return new User();
        }

        public void AddUser(User user) {
            List<User> @users = GetAllUsers();
            List<int> userIdent = new List<int>();
            foreach (var usr in users) {
                userIdent.Add(usr.UserId);
            }
            @users.Add(user);
            JsonFileWriter.WriteToJsonUsers(@users, jsonFileName);
        }
    }
}
