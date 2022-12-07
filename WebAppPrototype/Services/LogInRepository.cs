using WebAppPrototype.Models;
namespace WebAppPrototype.Services {
    public class LogInRepository {
        private User _UserLoggedIn;

        public void UserLogIn(User user) {
            _UserLoggedIn = user;
        }
        public void UserLogOut() {
            _UserLoggedIn = null;
        }
        public User GetLoggedUser() { 
            return _UserLoggedIn; 
        }
    }
}
