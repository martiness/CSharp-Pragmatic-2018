
namespace Task2
{
    public class AuthenticationService
    {
        private User[] _users;

        public AuthenticationService()
        {
            _users = new User[3];

            _users[0] = new User("Georgi", "Panayotov", "smg", "no_way_:)");

            _users[1] = new User("Tedi", "Todorov", "tedi", "123");

            _users[2] = new User("Stanislav", "Stoyanov", "stynkata", "777");
        }

        public bool AuthenticateUser(string username, string password)
        {
            bool isValidUser = false;
            foreach (var user in _users)
            {
                if (user.Username == username && user.Password == password)
                {
                    isValidUser = true;
                    break;
                }
            }

            return isValidUser;
        }
    }
}
