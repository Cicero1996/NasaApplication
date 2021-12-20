using System;
using NasaApplication.Models;
using System.Text;
using System.Security.Cryptography;
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
            string passSHA= ComputeSha256Hash(user.PasswordSha);

            if (user.Mail == u.Mail && passSHA == u.PasswordSha)
                return true;
            else
                return false;

        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }


}
