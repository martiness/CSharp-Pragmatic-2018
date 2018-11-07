
namespace Task2
{
    public class User
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Username { get; private set; }

        public string Password { get; set; }

        public User(string firstName, string lastName, 
            string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }
    }
}
