using System;
using NasaApplication.Models;

namespace NasaApplication.Services
{
    public class UserService
    {
        private User user;

        public UserService()
        {

            User u = new User("andrea-cicero@hotmail.it", "ciao1234");
 

        }
        public bool VerifiedUser(User u)
        {
            if (user.Mail == u.Mail && user.PasswordSha == u.PasswordSha)
                return true;
            else
                return false;

        }
    }
}
