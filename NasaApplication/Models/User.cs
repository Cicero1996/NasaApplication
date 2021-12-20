using System;
namespace NasaApplication.Models
{
    public class User
    {

        private string mail;
        private string password;
        private string name;

        public User(string mail, string password)
        {
            this.mail = mail;
            this.password = password;
        }


        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public string PasswordSha
        {
            get => password;
            set => password = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

    }
}
