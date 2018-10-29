using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AuthenticationManager
    {
        private readonly AuthenticationService _authenticationService
            = new AuthenticationService();

        public void Login()
        {
            var isValidUser = false;
            do
            {
                Console.Clear();

                Console.Write("Username: ");
                var username = Console.ReadLine();

                Console.Write("Password: ");
                var password = Console.ReadLine();

                if (_authenticationService.AuthenticateUser(username, password))
                {
                    isValidUser = true;
                }
            } while (!isValidUser);


            Console.WriteLine("Welcome aboard!");
        }
    }
}
